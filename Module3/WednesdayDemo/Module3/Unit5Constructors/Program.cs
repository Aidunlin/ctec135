/*
 * Name: Aidan Linerud
 * Date: 10/11/2023
 * Assignment: Wednesday Demo
 */

namespace Unit5Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            Employee employee = new Employee("Aidan", 104921, 42);
            employee.PrintState();

            Employee e2 = new Employee();
            e2.PrintState();
        }
    }
}