﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Net;



namespace FIONA
{
    public class ClientConnection
    {
        private TcpClient _controlClient;

        private NetworkStream _controlStream;
        private StreamReader _controlReader;
        private StreamWriter _controlWriter;

        private string _username;
        private string _transferType;
        private TcpListener _passiveListener;
        private bool conn_type_passive;
        private IPEndPoint _dataEndpoint;
        private string _currentDirectory = "C:\\fiona";
        private string _root = "C:\\fiona";
        private TcpClient _dataClient;
        private StreamReader _dataReader;
        private StreamWriter _dataWriter;


        public ClientConnection(TcpClient client, string root)
        {
            _currentDirectory = root;
            _root = root;

            _controlClient = client;

            _controlStream = _controlClient.GetStream();

            _controlReader = new StreamReader(_controlStream);
            _controlWriter = new StreamWriter(_controlStream);
        }

        public void HandleClient(object obj)
        {
            _controlWriter.WriteLine("220 Service Ready.");
            _controlWriter.Flush();


            string line;

            try
            {
                while (!string.IsNullOrEmpty(line = _controlReader.ReadLine()))
                {
                    string response = null;

                    string[] command = line.Split(' ');

                    string cmd = command[0].ToUpperInvariant();
                    string arguments = command.Length > 1 ? line.Substring(command[0].Length + 1) : null;

                    if (string.IsNullOrWhiteSpace(arguments))
                        arguments = null;

                    if (response == null)
                    {
                        Console.WriteLine("" + cmd);
                        switch (cmd)
                        {
                            case "USER":
                                response = User(arguments);
                                break;
                            case "PASS":
                                response = Password(arguments);
                                break;
                            case "CWD":
                                response = ChangeWorkingDirectory(arguments);
                                break;
                            case "CDUP":
                                response = ChangeWorkingDirectory("..");
                                break;
                            case "PWD":
                                response = PrintWorkingDirectory();
                                break;
                            case "QUIT":
                                response = "221 Service closing control connection";
                                break;
                            case "TYPE":
                                string[] splitArgs = arguments.Split(' ');
                                response = Type(splitArgs[0], splitArgs.Length > 1 ? splitArgs[1] : null);
                                break;
                            case "PORT":
                                Console.WriteLine("port called");
                                response = Port(arguments);
                                break;
                            case "PASV":
                                response = Passive();
                                break;
                            case "LIST":
                                response = List(arguments ?? _currentDirectory);
                                break;
                            case "RETR":
                                response = Retrieve(arguments);
                                break;

                            default:
                                response = "502 Command not implemented";
                                break;
                        }
                    }

                    if (_controlClient == null || !_controlClient.Connected)
                    {
                        break;
                    }
                    else
                    {
                        _controlWriter.WriteLine(response);
                        _controlWriter.Flush();

                        if (response.StartsWith("221"))
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        #region FTP Commands

        private string User(string username)
        {
            _username = username;

            return "331 Username ok, need password";
        }

        private string Password(string password)
        {
            return "230 User logged in";
        }

        private string Port(string hostPort)
        {
            string[] ipAndPort = hostPort.Split(',');

            byte[] ipAddress = new byte[4];
            byte[] port = new byte[2];

            for (int i = 0; i < 4; i++)
            {
                ipAddress[i] = Convert.ToByte(ipAndPort[i]);
            }

            for (int i = 4; i < 6; i++)
            {
                port[i - 4] = Convert.ToByte(ipAndPort[i]);
            }

            if (BitConverter.IsLittleEndian)
                Array.Reverse(port);

            IPAddress wubbs = new IPAddress(ipAddress);

            for (int i = 0; i < port.Length; i++)
            {
                Console.WriteLine(port[i]);
            }

            ushort wtf = (ushort)BitConverter.ToInt16(port, 0);


            _dataEndpoint = new IPEndPoint(new IPAddress(ipAddress), wtf);

            return "200 Data Connection Established";

        }

        private string Passive()
        {

            conn_type_passive = true;

            IPAddress localAddress = ((IPEndPoint)_controlClient.Client.LocalEndPoint).Address;

            _passiveListener = new TcpListener(localAddress, 0);
            _passiveListener.Start();

            IPEndPoint localEndpoint = (IPEndPoint)_passiveListener.LocalEndpoint;

            byte[] address = localEndpoint.Address.GetAddressBytes();
            short port = (short)localEndpoint.Port;

            byte[] portArray = BitConverter.GetBytes(port);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(portArray);

            return string.Format("227 Entering Passive Mode ({0},{1},{2},{3},{4},{5})",
                          address[0], address[1], address[2], address[3], portArray[0], portArray[1]);
        }

        private string List(string pathname)
        {
            Console.WriteLine("List command pathname: " + pathname);
            if (pathname == null)
            {
                pathname = string.Empty;
            }
            Console.WriteLine(_currentDirectory);
            pathname = new DirectoryInfo(Path.Combine(_currentDirectory, pathname)).FullName;
            Console.WriteLine(pathname);

            if (!conn_type_passive)
            {
                Console.WriteLine("test2");

                _dataClient = new TcpClient();
                Console.WriteLine(_dataEndpoint.Address);
                _dataClient.BeginConnect(_dataEndpoint.Address, _dataEndpoint.Port, DoList, pathname);
            }
            else
            {
                _passiveListener.BeginAcceptTcpClient(DoList, pathname);
            }

            return string.Format("150 Opening {0} mode data transfer for LIST", conn_type_passive ? ": passive" : ": active");
        }

        private void DoList(IAsyncResult result)
        {
            if (!conn_type_passive)
            {
                _dataClient.EndConnect(result);
            }
            else
            {
                _dataClient = _passiveListener.EndAcceptTcpClient(result);
            }

            string pathname = (string)result.AsyncState;
            Console.WriteLine("DoList pathname: " + pathname);


            using (NetworkStream dataStream = _dataClient.GetStream())
            {
                _dataReader = new StreamReader(dataStream, Encoding.ASCII);
                _dataWriter = new StreamWriter(dataStream, Encoding.ASCII);

                IEnumerable<string> directories = Directory.EnumerateDirectories(pathname);

                foreach (string dir in directories)
                {
                    Console.WriteLine("DoList dir" + dir);
                    DirectoryInfo d = new DirectoryInfo(dir);

                    string date = d.LastWriteTime < DateTime.Now - TimeSpan.FromDays(180) ?
                        d.LastWriteTime.ToString("MMM dd  yyyy") :
                        d.LastWriteTime.ToString("MMM dd HH:mm");

                    string line = string.Format("drwxr-xr-x    2 2003     2003     {0,8} {1} {2}", "4096", date, d.Name);

                    _dataWriter.WriteLine(line);
                    _dataWriter.Flush();
                }

                IEnumerable<string> files = Directory.EnumerateFiles(pathname);

                foreach (string file in files)
                {
                    FileInfo f = new FileInfo(file);

                    string date = f.LastWriteTime < DateTime.Now - TimeSpan.FromDays(180) ?
                        f.LastWriteTime.ToString("MMM dd  yyyy") :
                        f.LastWriteTime.ToString("MMM dd HH:mm");

                    string line = string.Format("-rw-r--r--    2 2003     2003     {0,8} {1} {2}", f.Length, date, f.Name);

                    _dataWriter.WriteLine(line);
                    _dataWriter.Flush();
                }

                _dataClient.Close();
                _dataClient = null;

                _controlWriter.WriteLine("226 Transfer complete");
                _controlWriter.Flush();
            }
        }

        private string Retrieve(string pathname)
        {
            if (!conn_type_passive)
            {
                _dataClient = new TcpClient();
                _dataClient.BeginConnect(_dataEndpoint.Address, _dataEndpoint.Port, DoRetrieve, pathname);
            }
            else
            {
                _passiveListener.BeginAcceptTcpClient(DoRetrieve, pathname);
            }

            return string.Format("150 Opening {0} mode data transfer for RETR", conn_type_passive ? "passive" : "active");
        }

        private void DoRetrieve(IAsyncResult result)
        {
            if (!conn_type_passive)
            {
                _dataClient.EndConnect(result);
            }
            else
            {
                _dataClient = _passiveListener.EndAcceptTcpClient(result);
            }

            string pathname = Path.Combine(_currentDirectory, (string)result.AsyncState);

            using (NetworkStream dataStream = _dataClient.GetStream())
            {
                using (FileStream fs = new FileStream(pathname, FileMode.Open, FileAccess.Read))
                {
                    CopyStream(fs, dataStream);
                    _dataClient.Close();
                    _dataClient = null;
                }
            }
        }

        private static long CopyStream(Stream input, Stream output, int bufferSize)
        {
            byte[] buffer = new byte[bufferSize];
            int count = 0;
            long total = 0;

            while ((count = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, count);
                total += count;
            }
            return total;
        }

        private static long CopyStreamAscii(Stream input, Stream output, int bufferSize)
        {
            char[] buffer = new char[bufferSize];
            int count = 0;
            long total = 0;

            using (StreamReader rdr = new StreamReader(input))
            {
                using (StreamWriter wtr = new StreamWriter(output, Encoding.ASCII))
                {
                    while ((count = rdr.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        wtr.Write(buffer, 0, count);
                        total += count;
                    }
                }
            }
            return total;
        }

        private long CopyStream(Stream input, Stream output)
        {
            if (_transferType == "I")
            {
                return CopyStream(input, output, 4096);
            }
            else
            {
                return CopyStreamAscii(input, output, 4096);
            }
        }



        private bool IsPathValid(string path)
        {
            return path.StartsWith(_root);
        }

        private string Type(string typeCode, string formatControl)
        {
            string response = "500 ERROR";

            switch (typeCode)
            {
                case "A":
                case "I":
                    _transferType = typeCode;
                    response = "200 OK";
                    break;
                case "E":
                case "L":
                default:
                    response = "504 Command not implemented for that parameter.";
                    break;
            }

            if (formatControl != null)
            {
                switch (formatControl)
                {
                    case "N":
                        response = "200 OK";
                        break;
                    case "T":
                    case "C":
                    default:
                        response = "504 Command not implemented for that parameter.";
                        break;
                }
            }
            return response;
        }

        private string ChangeWorkingDirectory(string pathname)
        {
            if (pathname == "/")
            {
                _currentDirectory = _root;
            }
            else
            {
                string newDir;

                if (pathname.StartsWith("/", StringComparison.OrdinalIgnoreCase))
                {
                    pathname = pathname.Substring(1).Replace('/', '\\');
                    newDir = Path.Combine(_root, pathname);
                }
                else
                {
                    pathname = pathname.Replace('/', '\\');
                    newDir = Path.Combine(_currentDirectory, pathname);
                }
                if (Directory.Exists(newDir))
                {
                    Console.WriteLine(_currentDirectory);
                    _currentDirectory = new DirectoryInfo(newDir).FullName;
                    Console.WriteLine(newDir);
                    Console.WriteLine(_currentDirectory);

                    if (!IsPathValid(_currentDirectory))
                    {
                        _currentDirectory = _root;
                    }
                }
                else
                {
                    _currentDirectory = _root;
                }
            }
            return "200 OK";
        }

        private string PrintWorkingDirectory()
        {
            Console.WriteLine(_currentDirectory);
            string current = _currentDirectory.Replace(_root, string.Empty).Replace('\\', '/');

            if (current.Length == 0)
            {
                current = "/";
            }
            Console.WriteLine(_currentDirectory);

            return "257 " + _currentDirectory;
        }
        #endregion
    }
}