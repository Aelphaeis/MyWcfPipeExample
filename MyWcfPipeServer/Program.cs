using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWcfPipeTypes;

namespace MyWcfPipeServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyPipeServer server = new MyPipeServer()) 
            { 
                server.Open();
                Console.WriteLine("Press Enter to End Program");
                Console.ReadLine();
            }
            
        }
    }
}
