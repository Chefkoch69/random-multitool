using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace funny_bunny_hat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            logo();
            while (true)
            {
                Console.Write("~ ");
                var inp = Console.ReadLine();
                handler(inp);
            }

        }


        public static void handler(string input)
        {
            string[] args = input.Split(" ".ToCharArray());
            string command = args[0];



            switch (command)
            {
                case "namp":
                    var wc = new WebClient();
                    string res = wc.DownloadString("https://api.hackertarget.com/nmap/?q=" + args[1]);
                    Console.WriteLine(res);
                    break;

                case "help":
                    help();
                    break;

                case "update":
                    
                    break;

                default:
                    Console.WriteLine("-> Command " + command + " not found");
                    break;

            }
        }

        public static void help()
        {

            Console.WriteLine(@"
 >-------------------------------------<
 | nmap ( IP ) => Scans a IP with nmap |
 | update => Updates this multitool    |
 >-------------------------------------<
");
        }

        public static void logo()
        {
            Console.WriteLine(@"
                                  ███████╗██╗███╗   ██╗███████╗██╗   ██╗██╗     ██╗     
                                  ██╔════╝██║████╗  ██║██╔════╝██║   ██║██║     ██║     
                                  ███████╗██║██╔██╗ ██║█████╗  ██║   ██║██║     ██║     
                                  ╚════██║██║██║╚██╗██║██╔══╝  ██║   ██║██║     ██║     
                                  ███████║██║██║ ╚████║██║     ╚██████╔╝███████╗███████╗
                                  ╚══════╝╚═╝╚═╝  ╚═══╝╚═╝      ╚═════╝ ╚══════╝╚══════╝
                                                      ");

        }
    }
}
