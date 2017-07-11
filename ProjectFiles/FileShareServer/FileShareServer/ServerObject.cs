using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace FileShareServer
{
    
    class ServerObject
    {
        private Socket Server;
        private IPEndPoint Address;
        private bool isAsync;
        public ServerObject(string LocalIpv4Address, int Port,bool isA = true)
        {
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Address = new IPEndPoint(IPAddress.Parse(LocalIpv4Address), Port);
            isAsync = isA;
            Console.WriteLine("SERVER_OBJECT: Server Created with an IP of " + LocalIpv4Address + " and a port of " + Port);
        }

        public void Start()
        {
            if (isAsync)
            {
                Server.Bind(Address);
                Server.Listen(100);
                Server.BeginAccept(null, Server);
                Console.WriteLine("SERVER_OBJECT: Async Server Started");
            }
            else{/* Empty For Now */}
            
            
        }
    }
}
