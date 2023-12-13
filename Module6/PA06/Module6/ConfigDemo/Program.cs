/*
 * Name: Aidan Linerud
 * Date: 11/1/2023
 * Assignment: PA06-2 Task 1
 */

using Microsoft.Extensions.Configuration;

namespace ConfigDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provider info");
            (string provider, string connectionString) = GetProviderFromConfiguration();
            Console.WriteLine($"\tProvider: {provider}");
            Console.WriteLine($"\tConnection string: {connectionString}");
        }

        static (string Provider, string ConnectionString) GetProviderFromConfiguration()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            return (config["ProviderName"], config["SqlServer:ConnectionString"]);
        }
    }
}
