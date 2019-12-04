using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Net;



namespace FIONA
{
    /**
     * Authors:
     *      Kyle Scheffler
     *      Ross White
     *      Adrian Yuson
     *      
     * Original Tutorial/Reference Code:
     *      rickbassham/sharp-ftp-server on github
     *      
     * ClientConnection class:
     *      This class is Used to handle ftp commands passed to the server.
     *      
     *      Implemented ftp Commands:
     *          USER - User - UNUSED
     *          PASS - Password - UNUSED
     *          CWD  - Change Working Directory
     *          CDUP - Move to parent directory
     *          PWD  - Print working directory
     *          QUIT - Quit
     *          TYPE - Type
     *          PORT - Port
     *          PASV - Passive
     *          LIST - List
     *          RETR - Retrieve
     * 
     * <summary>
     * Used to handle ftp commands passed to the server.
     * </summary>     
     */
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
        private string _currentDirectory;
        private string _root;
        private TcpClient _dataClient;
        private StreamReader _dataReader;
        private StreamWriter _dataWriter;

        /// <summary>
        /// Constructor for the ClientConnection object.
        /// </summary>
        /// <param name="client">client passed from calling ftp server</param>
        /// <param name="root">folder passed in which clients can access</param>
        public ClientConnection(TcpClient client, string root)
        {
            // setting class parameters
            _currentDirectory = root;
            _root = root;
            _controlClient = client;
            _controlStream = _controlClient.GetStream();
            // establishing stream readers and writers
            _controlReader = new StreamReader(_controlStream);
            _controlWriter = new StreamWriter(_controlStream);
        }

        /// <summary>
        /// this function handles requests from client
        /// first is parses the type of request, then routes to the appropriate class function
        /// </summary>
        /// <param name="obj"></param>
        public void HandleClient(object obj)
        {
            _controlWriter.WriteLine("220 Service Ready.");
            _controlWriter.Flush();

            string line;

            try
            {
                while (!string.IsNullOrEmpty(line = _controlReader.ReadLine()))
                {
                    // process request
                    string response = null;
                    string[] command = line.Split(' ');
                    string cmd = command[0].ToUpperInvariant();
                    string arguments = command.Length > 1 ? line.Substring(command[0].Length + 1) : null;

                    if (string.IsNullOrWhiteSpace(arguments))
                        arguments = null;

                    if (response == null)
                    {
                        // handles different types of requests from the client and redirects
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
                    // checks control client status and breaks out if required
                    if (_controlClient == null || !_controlClient.Connected)
                    {
                        break;
                    }
                    // otherwise writes response
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

        /// <summary>
        /// Validates the user on the server.
        /// Currently Unimplemented.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private string User(string username)
        {
            _username = username;

            return "331 Username ok, need password";
        }

        /// <summary>
        /// Validates the password with the server.
        /// Currently Unimplemented.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string Password(string password)
        {
            return "230 User logged in";
        }

        /// <summary>
        /// handles and processes the incoming port (active connection)
        /// </summary>
        /// <param name="hostPort">passed in port to be processed and linked to</param>
        /// <returns></returns>
        private string Port(string hostPort)
        {
            // separating passed in string
            string[] ipAndPort = hostPort.Split(',');
            byte[] ipAddress = new byte[4];
            byte[] port = new byte[2];

            // converts addess parts to bytes
            for (int i = 0; i < 4; i++)
            {
                ipAddress[i] = Convert.ToByte(ipAndPort[i]);
            }

            for (int i = 4; i < 6; i++)
            {
                port[i - 4] = Convert.ToByte(ipAndPort[i]);
            }

            //checks for endianess
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(port);
            }

            for (int i = 0; i < port.Length; i++)
            {
                Console.WriteLine(port[i]);
            }

            // creating an end point
            ushort new_port = (ushort)BitConverter.ToInt16(port, 0);
            _dataEndpoint = new IPEndPoint(new IPAddress(ipAddress), new_port);

            return "200 Data Connection Established";
        }

        /// <summary>
        /// handles a passive type connection
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// lists the contents of the file path provided
        /// </summary>
        /// <param name="pathname">provided file path</param>
        /// <returns></returns>
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

        /// <summary>
        /// this function actually transmits the data
        /// </summary>
        /// <param name="result"></param>
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

            // creates read and write streams and handles the data transfer chunk by chunk
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

                // stamps new files with parameters
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

        /// <summary>
        /// opens port for data retrieval
        /// </summary>
        /// <param name="pathname"></param>
        /// <returns></returns>
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

        /// <summary>
        /// creates a file stream based on given parameters
        /// </summary>
        /// <param name="result">response from client</param>
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

        /// <summary>
        /// cuts up 'image' data to be transferred into smaller chunks to send
        /// puts all data in a byte array buffer, and transmits piece by piece
        /// </summary>
        /// <param name="input">the input stram</param>
        /// <param name="output">the output stream</param>
        /// <param name="bufferSize">the buffer size</param>
        /// <returns></returns>
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

        /// <summary>
        /// cuts up ascii data to be transferred into smaller chunks to send
        /// puts all data in a byte array buffer, and transmits piece by piece
        /// </summary>
        /// <param name="input">the input stram</param>
        /// <param name="output">the output stream</param>
        /// <param name="bufferSize">the buffer size</param>
        /// <returns></returns>
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

        /// <summary>
        /// discriminates between ascii and 'image' data type transfers
        /// </summary>
        /// <param name="input">the input stram</param>
        /// <param name="output">the output stream</param>
        /// <returns></returns>
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

        /// <summary>
        /// confirms file path is valid relative to the root
        /// </summary>
        /// <param name="path">passed in file path</param>
        /// <returns></returns>
        private bool IsPathValid(string path)
        {
            return path.StartsWith(_root);
        }

        /// <summary>
        /// discriminates between tehe types of coedes passed in
        /// </summary>
        /// <param name="typeCode">first element of the split args array</param>
        /// <param name="formatControl">second element of the split args aray or null</param>
        /// <returns></returns>
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

        /// <summary>
        /// handles navigation to a different directory if requested
        /// </summary>
        /// <param name="pathname">passed in pathway</param>
        /// <returns></returns>
        private string ChangeWorkingDirectory(string pathname)
        {
            if (pathname == "/")
            {
                _currentDirectory = _root;
            }
            else
            {
                string newDir;
                // formatting the file path
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

        /// <summary>
        /// prints the working directory back to client
        /// </summary>
        /// <returns></returns>
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