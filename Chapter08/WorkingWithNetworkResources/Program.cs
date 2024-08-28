using System.Net;
using static System.Net.WebRequestMethods;
using System.Net.NetworkInformation;

namespace WorkingWithNetworkResources
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://stackoverflow.com/search?q=securestring";
            Uri uri = new Uri(url);
            Console.WriteLine($"URL: {url}");
            Console.WriteLine($"Scheme: {uri.Scheme}");
            Console.WriteLine($"Port: {uri.Port}");
            Console.WriteLine($"Host: {uri.Host}");
            Console.WriteLine($"Path: {uri.AbsolutePath}");
            Console.WriteLine($"Query: {uri.Query}");

            IPHostEntry entry = Dns.GetHostEntry(uri.Host);
            Console.WriteLine($"{entry.HostName} has the following IP addresses: ");
            foreach(IPAddress address in entry.AddressList)
            {
                Console.WriteLine($"   {address} ({address.AddressFamily})");
            }

            try
            {
                Ping ping = new();
                Console.WriteLine("Pinging server. Please wait...");
                PingReply reply = ping.Send(uri.Host);

                if(reply.Status == IPStatus.Success)
                {
                    Console.WriteLine($"Reply from {reply.Address} took {reply.RoundtripTime:N0}ms");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.GetType().ToString()} says {e.Message}");
            }
        }
    }
}
