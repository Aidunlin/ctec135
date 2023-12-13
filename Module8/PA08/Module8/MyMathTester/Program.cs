/*
 * Name: Aidan Linerud
 * Date: 11/28/2023
 * Assignment: PA08-1
 */

namespace MyMathTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Testing MyMath");
			Console.WriteLine($"\tSubtract(5, 2) results in: {MyMath.MyMath.Subtract(5, 2)}");
			Console.WriteLine($"\tSubtract(3, 7) results in: {MyMath.MyMath.Subtract(3, 7)}");
		}
    }
}
