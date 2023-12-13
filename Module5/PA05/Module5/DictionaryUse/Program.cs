/*
 * Name: Aidan Linerud
 * Date: 10/22/2023
 * Assignment: PA05
 */

namespace DictionaryUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "one";
            dict[2] = "two";
            dict[3] = "three";

            dict.Add(99, "ninety-nine");

            // Traversal
            Console.WriteLine();
            Console.WriteLine("Printing the dictionary using explicit type");
            foreach (KeyValuePair<int, string> item in dict)
                Console.WriteLine($"\tkey: {item.Key}\tvalue: {item.Value}");

            Console.WriteLine();
            Console.WriteLine("Printing the dictionary using implicit type");
            foreach (var item in dict)
                Console.WriteLine($"\tkey: {item.Key}\tvalue: {item.Value}");

            // Add/modify
            dict[99] = "99";

            // Access
            Console.WriteLine();
            Console.WriteLine("Printing value of 99");
            Console.WriteLine($"\t{dict[99]}");

            // Remove
            dict.Remove(2);

            // Updated traversal
            Console.WriteLine();
            Console.WriteLine("Printing the updated dictionary");
            foreach (var item in dict)
                Console.WriteLine($"\tkey: {item.Key}\tvalue: {item.Value}");
        }
    }
}