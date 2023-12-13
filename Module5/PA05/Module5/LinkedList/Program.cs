/*
 * Name: Aidan Linerud
 * Date: 10/22/2023
 * Assignment: PA05
 */

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize from string array
            string[] rhyme = "The wheels on the bus go round and round"
                .Split(" ");

            LinkedList<string> stringList = new LinkedList<string>(rhyme);

            // Traversal
            Console.WriteLine();
            Console.WriteLine("Printing the list");
            Console.Write("\t");
            foreach (var item in stringList)
                Console.Write($"{item} ");
            Console.WriteLine();

            // Traversal by walking
            Console.WriteLine();
            Console.WriteLine("Printing the list by walking it");
            Console.Write("\t");
            LinkedListNode<string>? walker = stringList.First;
            while (walker != null)
            {
                Console.Write($"{walker.Value} ");
                walker = walker.Next;
            }
            Console.WriteLine();

            // Remove
            stringList.Remove("bus");

            // Updated traversal
            Console.WriteLine();
            Console.WriteLine("Printing the updated list");
            Console.Write("\t");
            foreach (var item in stringList)
                Console.Write($"{item} ");
            Console.WriteLine();

            // Add back in
            LinkedListNode<string>? node = stringList.Find("go");
            if (node != null)
                stringList.AddBefore(node, "bus");

            // Updated traversal
            Console.WriteLine();
            Console.WriteLine("Printing the updated list");
            Console.Write("\t");
            foreach (var item in stringList)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }
}