using System.Net;
using System.Threading.Tasks;

namespace Nule.Client
{
    public abstract class Client
    {
        public abstract NetworkID _clientID {get; set;}
        public abstract IPEndPoint _endPoint { get; set;}

        public  abstract Task ConnectToHost(string address, int port);

        public abstract Task Disconnect();

        public abstract Task SendHost();
        
        public abstract Task RecieveHost();


    }    
}

