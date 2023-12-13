/*
 * Name: Aidan Linerud
 * Date: 12/1/2023
 * Assignment: PA08-2
 */

namespace BubbleSort
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 3, 0, 1, 8, 7, 2, 5, 4, 6, 9 };

			Console.WriteLine("UNSORTED");
			PrintArray(array);

			BubbleSort(array);
		}

		/// <summary>
		/// Prints each item in an int array in a single line.
		/// </summary>
		/// <param name="array">The array to print out.</param>
		static void PrintArray(int[] array)
		{
			Console.Write("\t");
			foreach (int i in array)
				Console.Write($"{i} ");
			Console.WriteLine("\n");
		}

		/// <summary>
		/// Sorts an int array in-place using bubble sort,
		/// while recording traversal and swap information.
		/// </summary>
		/// <param name="array">The array to sort.</param>
		static void BubbleSort(int[] array)
		{
			// Incremented total of sort traversals.
			int traversals = 0;
			// The total number of times where two values in the array swapped.
			int totalSwaps = 0;
			// Whether a specific traversal had any swaps.
			bool swapped;

			// Keep traversing over and over until no values have been swapped.
			while (true)
			{
				swapped = false;

				// The number of swaps for this specific traversal.
				int swaps = 0;

				// Each traversal goes from the start of the array to the end,
				// though starts at i = 1 to easily compare each value to the
				// next one.
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i - 1] > array[i])
					{
						// Tuple swap is more concise than using temp variable.
						(array[i], array[i - 1]) = (array[i - 1], array[i]);
						
						swapped = true;
						swaps++;
					}
				}

				totalSwaps += swaps;
				traversals++;

				if (!swapped) break;

				// Record this traversal's info.
				Console.WriteLine($"Traversal {traversals}");
				Console.WriteLine($"{swaps} swaps ({totalSwaps} total)");
				PrintArray(array);
			}

			// Print out final results.
			Console.WriteLine("SORTED");
			Console.WriteLine($"{traversals} traversals");
			Console.WriteLine($"{totalSwaps} total swaps");
			PrintArray(array);
		}
	}
}