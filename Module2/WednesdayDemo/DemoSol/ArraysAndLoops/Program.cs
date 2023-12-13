/*
 * Name: Aidan Linerud
 */

namespace ArraysAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region Arrays
            int[] myArrayOfInts = new int[3];
            #endregion

            #region Simple for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\t{i}");
            }

            // demo init
            for (int i = 0; i < myArrayOfInts.Length; i++)
            {
                myArrayOfInts[i] = (i + 1) * 100;
            }
            #endregion

            Console.WriteLine();

            #region Foreach loop
            foreach (int element in myArrayOfInts)
            {
                Console.WriteLine($"\t{element}");
            }
            #endregion

            Console.WriteLine();
        }
    }
}