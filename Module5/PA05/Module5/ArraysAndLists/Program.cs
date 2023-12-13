/*
 * Name: Aidan Linerud
 * Date: 10/22/2023
 * Assignment: PA05
 */

namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple array

            // Declare
            int[] intArray = new int[5];

            // Initialize
            for (int i = 0; i < intArray.Length; i++)
                intArray[i] = i + 11;

            // Traversal
            Console.WriteLine();
            Console.WriteLine("Printing ints array");
            foreach (int value in intArray)
                Console.WriteLine($"\t{value}");

            #endregion

            #region List<T>

            // Declare
            List<int> intList = new List<int>();

            // Initialize
            for (int i = 0; i < 5; i++)
                intList.Add(i + 21);

            // Traversal
            Console.WriteLine();
            Console.WriteLine("Printing int list");
            foreach (int value in intList)
                Console.WriteLine($"\t{value}");

            // Modify
            for (int i = 0; i < intList.Count; i++)
                intList[i] += 10;

            // Updated traversal
            Console.WriteLine();
            Console.WriteLine("Printing updated list");
            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine($"\t{intList[i]}");

            #endregion
        }
    }
}
