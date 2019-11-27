using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace GenericHostSample
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureHostConfiguration(configHost =>
                {
                    configHost.SetBasePath(Directory.GetCurrentDirectory());
                })
            Console.WriteLine("Hello World!");
        }
    }
}
