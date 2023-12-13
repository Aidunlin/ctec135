/*
 * Name: Aidan Linerud
 * Date: 10/30/2023
 * Assignment: Monday Demo
 */

using System.Data.Common;

namespace MondayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            int[] myArray = new int[] { 1, 2, 3 };
            Stack<int> stack = new Stack<int>(myArray);

            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
