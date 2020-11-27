using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Updater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-> Updating");
            WebClient wc = new WebClient();
            if (File.Exists("sinfull.exe"))
            {
                File.Delete("sinfull.exe");
                Console.WriteLine("-> Deleted old Version");
            }
            wc.DownloadFile("https://github.com/Chefkoch69/random-multitool/raw/master/funny%20bunny%20hat/funny%20bunny%20hat/bin/Debug/funny%20bunny%20hat.exe", "sinfull.exe");
            Console.WriteLine("-> Done");
            Process.Start("sinfull.exe");
            Environment.Exit(0);
           
        }
    }
}
