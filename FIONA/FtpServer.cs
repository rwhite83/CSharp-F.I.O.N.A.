﻿using System;
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

        public FtpServer(Application app, string root)
        {
            _app = app;
            _root = root;
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, 21);
            _listener.Start();
            _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);
        }

        public void Stop()
        {
            if (_listener != null)
            {
                _listener.Stop();
            }
        }

        private void HandleAcceptTcpClient(IAsyncResult result)
        {
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