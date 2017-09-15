using System;
using System.Net.Http;

namespace HttpClient_test
{
    public class Static_HttpClient
    {
        static HttpClient client = new HttpClient {  BaseAddress = new Uri("http://iqans.com") };

        public static void Run()
        {
            Console.WriteLine("BEFORE");
            PortDetails.PrintPortDetails();

            Console.WriteLine("Connection start.");

            for (int i = 0; i < 10; i++)
            {
                var response = client.GetAsync("/");
                var content = response.Result;
                Console.WriteLine("status: " + content.StatusCode);
            }

            Console.WriteLine();
            Console.WriteLine("Connection end.");
            Console.WriteLine("AFTER");
            PortDetails.PrintPortDetails();
        }
    }
}
