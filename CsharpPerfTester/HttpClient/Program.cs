using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClient_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entry points:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. HttpClient in Using");
            Console.WriteLine("2. HttpClient static");
            Console.WriteLine("-------------------------");
            Console.WriteLine();
            Console.WriteLine("Entry point?");
            var entryPoint = Console.ReadLine();

            switch (entryPoint)
            {
                case "2":
                    Static_HttpClient.Run();
                    break;
                case "1":
                default:
                    Using_HttpClient.Run();
                    break;
            }

            Console.WriteLine("Press [Enter] to exit.");
            Console.ReadLine();
        }
    }
}
