using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.IO;

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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" root@Sinfull:-# ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
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
                    if (File.Exists("Updater.exe"))
                    {
                        Process.Start("Updater.exe");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("-> you dont have the updater installer...");
                        Console.WriteLine("-> Installing it for you...");
                        var wcy = new WebClient();
                        wcy.DownloadFile("https://github.com/Chefkoch69/random-multitool/raw/master/funny%20bunny%20hat/Updater/bin/Debug/Updater.exe", "Updater.exe");
                    }
                    break;

                default:
                    if(command == "")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("-> Command " + command + " not found");
                    }
                    
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
