using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace FIONA
{
    public class FtpServer
    {
        Application _app;
        private TcpListener _listener;
        private string _root;

        /// <summary>
        /// sets object application reference and root
        /// we believe there to be a way to check for an open tcp listener directly, but this has not yet been implemented
        /// </summary>
        /// <param name="app">must pass in a reference to the sending application to check current connection status</param>
        /// <param name="root">this is a value for the directory the application will offer sub folders and files from to client</param>
        public FtpServer(Application app, string root)
        {
            _app = app;
            _root = root;
        }

        /// <summary>
        /// starts the ftp server, currently allowing any ip to access.
        /// </summary>
        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, 21);
            _listener.Start();
            _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);
        }

        /// <summary>
        /// stops the ftp server
        /// </summary>
        public void Stop()
        {
            if (_listener != null)
            {
                _listener.Stop();
            }
        }

        /// <summary>
        /// continuously listens for attemps to connect to the tcp server
        /// </summary>
        /// <param name="result"></param>
        private void HandleAcceptTcpClient(IAsyncResult result)
        {
            // checks first if the state of the server through app
            if (_app.connectionStarted)
            {
                _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);
                TcpClient client = _listener.EndAcceptTcpClient(result);

                ClientConnection connection = new ClientConnection(client, _root);

                ThreadPool.QueueUserWorkItem(connection.HandleClient, client);
            }
        }
    }
}