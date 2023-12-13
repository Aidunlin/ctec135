/*
 * Name: Aidan Linerud
 * Date: 10/16/2023
 * Assignment: Monday Demo
 */

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrandChild gc = new GrandChild(123, 456, 789);
            gc.GCMethod();
            gc.childMethod();
            gc.baseMethod();
            gc.PrintState();

            Console.WriteLine();

            Child child = new Child(777, 888);
            child.childMethod();
            child.baseMethod();
        }
    }
}