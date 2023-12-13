/*
 * Author: Aidan Linerud
 * Date: 10/10/2023
 * Assignment: PA03
 */

namespace ClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region 7. Testing the class

            Student student1 = new Student("Aidan", "Washougal, WA", 589393);
            student1.PrintState();
            Console.WriteLine();

            Student student2 = new Student("Bob");
            student2.PrintState();
            Console.WriteLine();

            Student student3 = new Student();
            student3.PrintState();
            Console.WriteLine();

            #endregion
        }
    }
}