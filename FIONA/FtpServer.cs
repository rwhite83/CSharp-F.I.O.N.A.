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
        private TcpListener _listener;
        private bool _connectionStarted;

        public bool connectionStarted
        {
            get
            {
                return _connectionStarted;
            }
            set
            {
                _connectionStarted = value;
            }
        }


        public FtpServer()
        {
            connectionStarted = false;
        }

        public void Start()
        {
            _listener = new TcpListener(IPAddress.Any, 21);
            _listener.Start();
            _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);
            connectionStarted = true;
        }

        public void Stop()
        {
            if (_listener != null)
            {
                _listener.Stop();
                connectionStarted = false;
            }
        }

        private void HandleAcceptTcpClient(IAsyncResult result)
        {
            _listener.BeginAcceptTcpClient(HandleAcceptTcpClient, _listener);
            TcpClient client = _listener.EndAcceptTcpClient(result);

            ClientConnection connection = new ClientConnection(client);

            ThreadPool.QueueUserWorkItem(connection.HandleClient, client);
        }
    }
}