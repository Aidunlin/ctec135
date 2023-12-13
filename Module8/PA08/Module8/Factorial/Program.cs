/*
 * Name: Aidan Linerud
 * Date: 12/1/2023
 * Assignment: PA08-3
 */

namespace Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Factorial");
			for (uint i = 0; i <= 10; i++)
				Console.WriteLine($"\t{i}\t{Factorial(i)}");
		}

		/// <summary>
		/// Recursively calculates the factorial of an unsigned int (n!).
		/// </summary>
		/// <param name="n">The number to calculate.</param>
		/// <returns>
		/// The product of all positive integers less than or equal to n.
		/// </returns>
		static uint Factorial(uint n)
		{
			// Base/terminating case.
			if (n == 0) return 1;

			// Otherwise, recursively calls this function with
			// the next lower integer.
			return n * Factorial(n - 1);
		}
	}
}