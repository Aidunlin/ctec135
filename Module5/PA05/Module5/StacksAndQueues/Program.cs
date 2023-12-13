/*
 * Name: Aidan Linerud
 * Date: 10/22/2023
 * Assignment: PA05
 */

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack

            // Declare and initialize
            Stack<int> intStack = new Stack<int>(new int[] { 1, 2, 3, 4, 5 });

            // Traversal
            Console.WriteLine();
            Console.WriteLine("Printing the stack");
            foreach (int value in intStack)
                Console.WriteLine($"\t{value}");

            // Access
            Console.WriteLine();
            Console.WriteLine($"Top of Stack: {intStack.Peek()}");
            
            // Removal while traversing
            Console.WriteLine();
            Console.WriteLine("Printing the stack");
            while (intStack.Count > 0)
                Console.WriteLine($"\t{intStack.Pop()}");

            #endregion

            #region Queue

            // Declare
            Queue<int> intQueue = new Queue<int>();

            // Initialize
            for (int i = 0; i < 5; i++)
                intQueue.Enqueue(i + 1);

            // Traversal
            Console.WriteLine();
            Console.WriteLine("Print the queue");
            foreach (int value in intQueue)
                Console.WriteLine($"\t{value}");

            // Access
            Console.WriteLine();
            Console.WriteLine($"Top of queue: {intQueue.Peek()}");
            
            // Removal while traversing
            Console.WriteLine();
            Console.WriteLine("Dequeue and print values");
            while (intQueue.Count > 0)
                Console.WriteLine($"\t{intQueue.Dequeue()}");

            #endregion
        }
    }
}