/*
 * Name: Aidan Linerud
 * Date: 11/1/2023
 * Assignment: Wednesday Demo
 */

using Microsoft.Extensions.Configuration;

namespace WednesdayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            string? provider = config["ProviderName"];
            string? connection = config[provider + ":ConnectionString"];
            Console.WriteLine($"{provider}: {connection}");

            var car = new Car();
            IConfigurationSection section = config.GetSection("Car");
            section.Bind(car);
            Console.WriteLine($"Car Make: {car.Make} Color: {car.Color} PetName: {car.PetName}");
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Color { get; set; }
        public string PetName { get; set; }
    }
}
