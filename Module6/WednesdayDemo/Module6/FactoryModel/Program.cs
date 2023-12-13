/*
 * Name: Aidan Linerud
 * Date: 11/1/2023
 * Assignment: Wednesday Demo
 */

using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace FactoryModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (provider, connectionString) = GetProvider();
            Console.WriteLine($"Provider: {provider} Connection: {connectionString}");

            DbProviderFactory factory = GetDBProviderFactory(provider);

            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;
                connection.Open();

                DbCommand command = factory.CreateCommand();
                command.Connection = connection;
                command.CommandText = "Select i.Id, m.Name from Inventory i inner join Makes m on m.Id = i.MakeId";

                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        Console.WriteLine($"-> Car #{reader["Id"]} is a {reader["Name"]}");
                }
            }
        }

        static (string Provider, string Connection) GetProvider()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string provider = config["ProviderName"];
            string connection = config[provider + ":ConnectionString"];

            return (provider, connection);
        }

        static DbProviderFactory GetDBProviderFactory(string provider)
        {
            if (provider == "SqlServer")
                return SqlClientFactory.Instance;

            return null;
        }
    }
}