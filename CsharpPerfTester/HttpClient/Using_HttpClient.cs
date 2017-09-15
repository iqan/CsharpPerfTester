using System.Net.Http;
using System;
using System.Linq;

namespace HttpClient_test
{
    public class Using_HttpClient
    {
        public static void Run()
        {
            Console.WriteLine("BEFORE");
            PortDetails.PrintPortDetails();

            Console.WriteLine("Connection start.");

            for (int i = 0; i < 10; i++)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://iqans.com");
                    var response = client.GetAsync("/");
                    var content = response.Result;
                    Console.WriteLine("status: " + content.StatusCode);
                }
            }            

            Console.WriteLine();
            Console.WriteLine("Connection end.");
            Console.WriteLine("AFTER");
            PortDetails.PrintPortDetails();
        }
    }
}
