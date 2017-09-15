using System.Net.Http;

namespace HttpClient_test
{
    public class Using_HttpClient
    {
        public static void Run()
        {
            using (var client = new HttpClient())
            {

            }
        }
    }
}
