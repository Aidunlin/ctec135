/*
 * Name: Aidan Linerud
 * Date: 11/1/2023
 * Assignment: PA06-2 Task 2
 */

using static System.Console;

using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace FactoryDemo
{
    internal class Program
    {
        const string connectionStr = "Data Source=(localdb)\\mssqllocaldb;"
            + "Integrated Security=true;Initial Catalog=AutoLot";

        const string commandStr = "Select i.Id, m.Name From Inventory i "
            + "inner join Makes m on m.Id = i.MakeId";

        static void Main()
        {
            // Note: I'm using the 'using' declaration instead of the statement
            // here to de-nest code. In fact, the compiler suggested do so,
            // since it will know when to dispose of those DB objects (after
            // the last time they're used).

            // Use the sql client factory for the db provider
            DbProviderFactory factory = SqlClientFactory.Instance;

            // Create and open a connection to the db from connectionStr
            using DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionStr;
            connection.Open();

            // Create a command using the commandStr
            using DbCommand command = factory.CreateCommand();
            command.Connection = connection;
            command.CommandText = commandStr;

            // Executes the command and stores the resulting stream
            using DbDataReader reader = command.ExecuteReader();

            // Print out information
            WriteLine("Factory Model");
            WriteLine("\tProvider: SqlServer");
            WriteLine($"\tConnection string: \"{connectionStr}\"");
            WriteLine($"\tCommand string: \"{commandStr}\"");
            WriteLine();
            WriteLine($"\tConnection object: {connection.GetType()}");
            WriteLine($"\tCommand object: {command.GetType()}");
            WriteLine($"\tData reader object: {reader.GetType()}");
            WriteLine();
            WriteLine("\tCurrent inventory:");

            // Prints out all car ids and their make names
            while (reader.Read()) // Advances reader value to next car
                WriteLine($"\t\tCar #{reader["Id"]}: {reader["Name"]}");
        }
    }
}