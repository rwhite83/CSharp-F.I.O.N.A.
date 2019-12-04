using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FIONA
{
    /**
     * Author:
     *      Kyle Scheffler
     * 
     * Original Tutorial/Reference Code:
     *      metastruct on CodeProject.com
     *      
     * ftpClient class:
     *      Used to act as a client and connect to a currently sharing ftp
     *      server.
     * <summary>
     * Used to act as a client and connect to a currently sharing ftp
     * server to browse and download files.
     * </summary>
     */
    class ftpClient
    {
        private string host = null;
        private string user = null;
        private string pass = null;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private Stream ftpStream = null;
        private int bufferSize = 2048;

        /// <summary>
        /// Constructor for creating an ftpClient object.
        /// </summary>
        /// <param name="hostIP">The host's IP address.</param>
        /// <param name="userName">The username for the ftp server.</param>
        /// <param name="password">The password for the ftp server.</param>
        public ftpClient(string hostIP, string userName, string password)
        {
            host = hostIP;
            user = userName;
            pass = password;
        }

        /// <summary>
        /// Download a file from the connected ftp server.
        /// </summary>
        /// <param name="remoteFile">The file to be downloaded.</param>
        /// <param name="localFile">The name & path for the new file on the local system.</param>
        public void download(string remoteFile, string localFile)
        {
            try
            {
                Console.WriteLine("Remote File Name: " + remoteFile);

                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(@"ftp://localhost:21/" + Properties.Settings.Default.rootAppVar + "/" + remoteFile);
                ftpRequest.Credentials = new NetworkCredential(user, pass);

                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;

                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;

                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

                ftpStream = ftpResponse.GetResponseStream();

                FileStream localFileStream = new FileStream(localFile, FileMode.Create);

                byte[] byteBuffer = new byte[bufferSize];
                int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception occurred in ftpClient download\nTried to write to localFileStream\n" + ex.ToString());
                }
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred in ftpClient download\nFull try catch\n" + ex.ToString());
            }
            return;
        }

        /// <summary>
        /// Requests a simple directory list (names only) from the server.
        /// directory variable is currently unused since we were unable to get
        /// past directory listing.
        /// </summary>
        /// <param name="directory">Unused.</param>
        /// <returns></returns>
        public string[] directoryListSimple(string directory)
        {
            try
            {
                /* Create an FTP Request */
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(@"ftp://localhost:21/");
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
                /* Establish Return Communication with the FTP Server */
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Establish Return Communication with the FTP Server */
                ftpStream = ftpResponse.GetResponseStream();
                /* Get the FTP Server's Response Stream */
                StreamReader ftpReader = new StreamReader(ftpStream);
                /* Store the Raw Response */
                string directoryRaw = null;
                /* Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing */
                try
                {
                    while (ftpReader.Peek() != -1)
                    {
                        directoryRaw += ftpReader.ReadLine() + "|";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                /* Resource Cleanup */
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                /* Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) */
                try
                {
                    string[] directoryList = directoryRaw.Split("|".ToCharArray());
                    return directoryList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            /* Return an Empty string Array if an Exception Occurs */
            return new string[] { "" };
        }

        /* List Directory Contents in Detail (Name, Size, Created, etc.) */
        /// <summary>
        /// Requests a detailed directory listing from the server which
        /// includes the name, size, date created, date modified, etc.
        /// directory variable is currently unused since we were unable to get
        /// past directory listing.
        /// </summary>
        /// <param name="directory">Unused.</param>
        /// <returns></returns>
        public string[] directoryListDetailed(string directory)
        {
            try
            {
                /* Create an FTP Request */
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(@"ftp://localhost:21/");
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                /* Establish Return Communication with the FTP Server */
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

                Thread.Sleep(2000);//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX This is NOT the solution, only a bandaid.
                /* Establish Return Communication with the FTP Server */
                ftpStream = ftpResponse.GetResponseStream();
                /* Get the FTP Server's Response Stream */
                StreamReader ftpReader = new StreamReader(ftpStream);
                /* Store the Raw Response */
                string directoryRaw = null;
                /* Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing */
                try
                {
                    Console.WriteLine("Peek: " + ftpReader.Peek());
                    while (ftpReader.Peek() > -1)
                    {
                        directoryRaw += ftpReader.ReadLine() + "|";
                        Console.WriteLine("Peek: " + ftpReader.Peek());
                        Console.WriteLine("Raw Directory" + directoryRaw);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in ftpClient directoryListDetailed\nAttempt to read a line" + ex.ToString());
                }
                /* Resource Cleanup */
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                /* Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) */
                try
                {
                    string[] directoryList = directoryRaw.Split("|".ToCharArray());
                    return directoryList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception in ftpClient directoryListDetailed\nTrying to get directory as a string" + ex.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in ftpClient directoryListDetailed\nFull try catch" + ex.ToString());
            }
            /* Return an Empty string Array if an Exception Occurs */
            return new string[] { "" };
        }
    }
}
