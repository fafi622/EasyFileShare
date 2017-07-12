using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace FileShareServer
{
    class Program
    {
  
        static void Main(string[] args)
        {
            Console.WriteLine("FileShareServer Version: 1.1");
            Console.WriteLine("Commands: \n    -Create <IP> <Port>: Creates a socket server with the givin ip and port.\n    -Exit: exists the application");
         

            while (true)
            {
                
                switch (Console.ReadLine().ToLower())
                {
                  
                    case "server create":
                        string[] Response = Console.ReadLine().Split();
                        ServerObject server = new ServerObject(Response[0], Int32.Parse(Response[1]));
                        server.Start();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Sorry thats not a command. Use - server create <ip> <port> to create a server" );
                        break;
                        
                }
            }
        }
    }
}
