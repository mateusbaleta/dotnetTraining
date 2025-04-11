using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PortScanner
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Port Scanner with Banner Grabbing");
            Console.WriteLine("---------------------------------");

            Console.Write("Enter target IP: ");
            string ip = Console.ReadLine();

            Console.Write("Start Port: ");
            int startPort = int.Parse(Console.ReadLine());

            Console.Write("End Port: ");
            int endPort = int.Parse(Console.ReadLine());

            var scanner = new PortScanner();
            var results = await scanner.ScanAsync(ip, startPort, endPort);

            Console.WriteLine("\nScan Results:");
            foreach (var result in results)
            {
                Console.WriteLine($"Port {result.Port}: {(string.IsNullOrEmpty(result.Banner) ? "Filtered/Closed" : result.Banner)}");
            }
        }
    }

    public class ScanResult
    {
        public int Port { get; set; }
        public string Banner { get; set; }
    }

    public class PortScanner
    {
        public async Task<List<ScanResult>> ScanAsync(string ip, int startPort, int endPort)
        {
            var results = new List<ScanResult>();
            var tasks = new List<Task>();

            for (int port = startPort; port <= endPort; port++)
            {
                int currentPort = port;
                tasks.Add(Task.Run(async () =>
                {
                    var result = new ScanResult { Port = currentPort };
                    try
                    {
                        using (var client = new TcpClient())
                        {
                            await client.ConnectAsync(ip, currentPort);
                            if (client.Connected)
                            {
                                result.Banner = await GrabBannerAsync(client);
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // Port is closed/filtered
                    }
                    results.Add(result);
                }));
            }

            await Task.WhenAll(tasks);
            return results;
        }

        private async Task<string> GrabBannerAsync(TcpClient client)
        {
            try
            {
                var stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                return Encoding.ASCII.GetString(buffer, 0, bytesRead).Trim();
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}