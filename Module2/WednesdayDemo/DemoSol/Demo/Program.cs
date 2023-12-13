/*
 * Author: Aidan Linerud
 * Date: 10/4/2023
 * Assignment: Wednesday Demo
 */

using static System.Console;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine();

            #region Identifiers
            int myInt = 123;
            #endregion

            #region Exploring output
            WriteLine("Value of myInt is: {0}", myInt);
            WriteLine($"Value of myInt is: {myInt}");
            WriteLine("Sum of 2 + 2 is: {0}", 2 + 2);
            #endregion

            WriteLine("Lorem ipsum dolor sit amet, consectetur adipisicing e" +
                "lit. Repellendus temporibus maxime neque. Vel quo architect" +
                "o laudantium mollitia doloremque quos quia, nesciunt blandi" +
                "tiis voluptatum itaque! Dignissimos, tempora mollitia! Tene" +
                "tur, dolorem ea ?");

            WriteLine();

            #region User input example
            int someNumber = 0;
            Write("Enter a number: ");
            someNumber = Convert.ToInt32(ReadLine());
            WriteLine($"someNumber is: {someNumber}");
            #endregion

            WriteLine();

            #region Strings
            string myString = "Some text";
            //string myString2 = myString.ToUpper();
            myString = myString.ToUpper();

            WriteLine($"myString: {myString}");
            //WriteLine($"myString2: {myString2}");
            #endregion

            WriteLine();
        }
    }
}