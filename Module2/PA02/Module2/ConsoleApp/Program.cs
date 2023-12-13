/*
 * Author: Aidan Linerud
 * Date: 10/4/2023
 * Assignment: PA2
 */

using static System.Console;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine();

            #region Task2 Part 1
            int myInt = int.MaxValue;
            WriteLine("Fixed sized ints");

            WriteLine($"\tmyInt max value:\t{myInt}\t{myInt:X}");
            myInt++;
            WriteLine($"\tmyInt after increment:\t{myInt}\t{myInt:X}");
            myInt = 0;
            WriteLine($"\tmyInt zero:\t\t{myInt}\t\t{myInt:X}");
            myInt--;
            WriteLine($"\tmyInt -1:\t\t{myInt}\t\t{myInt:X}");
            #endregion

            #region Casting
            myInt = int.MaxValue;
            short myShort = (short)myInt;
            WriteLine("Casting");

            WriteLine($"\tmyInt max value:\t{myInt}\t{myInt:X}");
            WriteLine($"\tmyShort:\t\t{myShort}\t\t{myShort:X}");
            #endregion

            WriteLine();

            #region Loops
            int[] ints = new int[5];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i + 1;
            }

            WriteLine("Loops");
            Write("\t");
            foreach (int i in ints)
            {
                Write($"{i - 1} ");
            }
            WriteLine();
            #endregion

            WriteLine();

            #region Loop bonus
            WriteLine("\tMultiplication table");
            Write("\t");
            // Column headers
            foreach (int i in ints)
            {
                Write($"\t{i}");
            }
            WriteLine();
            Write("\t");

            // Horizontal line of dashes
            WriteLine(new string('-', ints.Length * 9));

            // Rows
            foreach (int y in ints)
            {
                // Row header
                Write($"\t{y} |");
                // Cells for this particular row
                foreach (int x in ints)
                {
                    Write($"\t{x * y}");
                }
                WriteLine();
            }
            WriteLine();
            #endregion

            WriteLine();

            #region Printer troubleshooter
            WriteLine("Printer Diagnostics");
            string conditions = "";
            Write("\tDoes the printer print (Y/N)? ");
            conditions += ReadLine();
            Write("\tIs the printer recognized by the computer (Y/N)? ");
            conditions += ReadLine();
            Write("\tIs the red light flashing (Y/N)? ");
            conditions += ReadLine();
            WriteLine();

            switch (conditions.ToUpper())
            {
                case "NYN":
                    WriteLine("\tCheck the printer-computer cable");
                    WriteLine("\tEnsure printer software is installed");
                    WriteLine("\tCheck/replace ink");
                    break;
                case "NYY":
                    WriteLine("\tCheck/replace ink");
                    WriteLine("\tCheck for paper jam");
                    break;
                case "NNN":
                    WriteLine("\tCheck the power cable");
                    WriteLine("\tCheck the printer-computer cable");
                    WriteLine("\tEnsure printer software is installed");
                    break;
                case "NNY":
                    WriteLine("\tCheck for paper jam");
                    break;
                case "YYN":
                    WriteLine("\tEnsure printer software is installed");
                    break;
                case "YYY":
                    WriteLine("\tCheck/replace ink");
                    break;
                case "YNN":
                    WriteLine("\tEnsure printer software is installed");
                    break;
                case "YNY":
                    WriteLine("\tEverything seems to be working correctly");
                    break;
                default:
                    WriteLine("\tInvalid response(s), please try again");
                    break;
            }
            #endregion

            WriteLine();
        }
    }
}