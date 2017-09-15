using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net;

namespace HttpClient_test
{
    public class PortDetails
    {
        public static void PrintPortDetails()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Ports connected to : 31.170.165.32");
            var ports = PortDetails.GetPortsInUse("31.170.165.32");

            foreach (var item in ports)
            {
                Console.Write("[" + item + "] ");
            }
            Console.WriteLine();
            Console.WriteLine("Total: " + ports.Count());
            Console.WriteLine("-----------------------------------------");
        }

        public static IEnumerable<int> GetPortsInUse(string ipAddress)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            TcpConnectionInformation[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpConnections();

            var ports = tcpConnInfoArray
                .Where(c=>c.RemoteEndPoint.Address.ToString() == ipAddress && c.State == TcpState.TimeWait)
                .Select(c => c.LocalEndPoint.Port);

            return ports;
        }
    }
}
