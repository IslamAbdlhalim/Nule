using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Nule.Client
{
    /// <summary>
    /// A singleton class that represents the client's TCP connection
    /// </summary>
    public sealed class TCPClientNule : Client
    {
        private TcpClient _client;
        private static TCPClientNule _instance = null;
        
        public override NetworkID _clientID { get; set; }
        public override IPEndPoint _endPoint { get; set; }


        public TCPClientNule(int port)
        {
            if (_instance is null)
            {
                throw new ArgumentException("An instance of TCP Client was already created");
                return;
            }

            _endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            _client = new TcpClient(_endPoint);
            _instance = this;
        }

        public void Dispose()
        {
            _instance = null;
        }

      
        public async override Task ConnectToHost(string address, int port)
        {
            try
            {
               await _client.ConnectAsync(IPAddress.Parse(address), port);
            }
            catch (Exception e)
            {
                throw e;
            }
            
            

        }

        public override Task Disconnect()
        {
            throw new NotImplementedException();
        }

        public override Task SendHost()
        {
            throw new NotImplementedException();
        }

        public override Task RecieveHost()
        {
            throw new NotImplementedException();
        }
    }
}
