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
                string[] command = Console.ReadLine().ToLower().Split();
                switch (command[0])
                {
                  
                    case "create":
                        ServerObject server = new ServerObject(command[1], Int32.Parse(command[2]));
                        server.Start();
                        break;

                    case "exit":
                        Environment.Exit(0);
                        break;

                    case "help":
                        Console.Clear();
                        Console.WriteLine("Commands: \n" +
                            "    -Create <IP> <Port>: Creates a socket server with the givin ip and port.\n" +
                            "    -Exit: Exists the application.\n" +
                            "    -Help: List all commands.");
                        break;

                    case "debug":
                        ServerObject master = new ServerObject("192.168.0.3", 25567);
                        master.Start();
                        break;

                    default:
                        Console.WriteLine("Sorry thats not a command. Use - server create <ip> <port> to create a server" );
                        break;
                        
                }
            }
        }
    }
}
