/*
 * Name: Aidan Linerud
 * Date: 10/11/2023
 * Assignment: Wednesday Demo
 */

namespace WednesdayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int someInt = 42;
            string[] strArray = new string[] { "one", "two", "three" };

            // Before method call print values
            Console.WriteLine("Before method call");
            Console.WriteLine($"\tsomeInt: {someInt}");
            Console.WriteLine("\tstrArray values:");
            foreach (string str in strArray)
            {
                Console.WriteLine($"\t\t{str}");
            }
            Console.WriteLine();

            // Call method
            SomeMethod(someInt, strArray);

            // After method call print values
            Console.WriteLine("After method call");
            Console.WriteLine($"\tsomeInt: {someInt}");
            Console.WriteLine("\tstrArray values:");
            foreach (string str in strArray)
            {
                Console.WriteLine($"\t\t{str}");
            }
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine($"2 + 3 = {add(2, 3)}");
            Console.WriteLine($"2 + 3.2 = {add(2, 3.2f)}");
        }

        static void SomeMethod(int arg1, string[] arg2)
        {
            Console.WriteLine("In method before changes");
            Console.WriteLine($"\targ1: {arg1}");
            Console.WriteLine("\targ2 values:");
            foreach (string str in arg2)
            {
                Console.WriteLine($"\t\t{str}");
            }
            Console.WriteLine();

            // Make some changes
            arg1 = 99;
            arg2[1] = "ninety-nine";

            Console.WriteLine("In method after changes");
            Console.WriteLine($"\targ1: {arg1}");
            Console.WriteLine("\targ2 values:");
            foreach (string str in arg2)
            {
                Console.WriteLine($"\t\t{str}");
            }
            Console.WriteLine();
        }

        static int add(int x, int y) => x + y;
        static float add(int x, float y) => x + y;
    }
}