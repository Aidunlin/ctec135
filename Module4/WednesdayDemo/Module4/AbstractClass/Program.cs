/*
 * Name: Aidan Linerud
 * Date: 10/18/2023
 * Assignment: Wednesday Demo
 */

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            //Abstract ac = new AbstractClass();
            ChildClass cc = new ChildClass();
            cc.CalculatePay();
        }
    }
}