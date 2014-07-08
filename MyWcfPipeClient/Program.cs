using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWcfPipeTypes;
using System.Threading;
namespace MyWcfPipeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyPipeClient client = new MyPipeClient())
            {
                Thread.Sleep(1000);
                Console.WriteLine(client.Hello("Marci"));
                Console.ReadLine();
            }
        }
    }
}
