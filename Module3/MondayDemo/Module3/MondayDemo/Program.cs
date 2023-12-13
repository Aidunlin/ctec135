/*
 * Author: Aidan Linerud
 * Date: 10/9/2023
 * Assignment: Module 3 Monday Demo
 */

namespace MondayDemo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        for (int row = 1; row < 11; row++)
        {
            Console.Write($"\t{row} |");
            for (int col = 1; col < 11; col++)
            {
                Console.Write("\t{0}", row * col);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
