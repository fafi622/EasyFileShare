using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace FileShareServer
{
    
    class ServerObject
    {

        //Server Vars
        private Socket Server;
        private IPEndPoint Address;
        private bool isAsync;
        private Thread CheckThread;
        //List for the clinets that connect
        private List<Socket> Clients = new List<Socket>();

        public ServerObject(string LocalIpv4Address, int Port,bool isA = true)
        {
            Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Address = new IPEndPoint(IPAddress.Parse(LocalIpv4Address), Port);
            isAsync = isA;
            Console.Clear();
            Console.WriteLine("SERVER_OBJECT: Server Created with an IP of " + LocalIpv4Address + " and a port of " + Port);
        }

        public void Start()
        {
            if (isAsync)
            {
                Server.Bind(Address);
                Server.Listen(100);
                Server.BeginAccept(onAccept, Server);
                CheckThread = new Thread(clientListCheck);
                CheckThread.Start();
                Console.WriteLine("SERVER_OBJECT: Async Server Started");
            }
            else{/* Empty For Now */}
            
            
        }

        public void clientListCheck()
        {
            while (true)
            {
                
                for(int i = 0; i < Clients.Count; i++)
                {
                    bool part1 = Clients[i].Poll(1000, SelectMode.SelectRead);
                    bool part2 = (Clients[i].Available == 0);
                    if (part1 && part2)
                    {
                        Console.WriteLine("Client Dissconnected");
                        Clients.Remove(Clients[i]);
                    }
                }
            }
        }
        public void onAccept(IAsyncResult ar)
        {
            Console.WriteLine("SERVER_OBJECT: Client has connected");
            Socket client = ((Socket)ar.AsyncState).EndAccept(ar);
            Clients.Add(client);
        }
    }
}
