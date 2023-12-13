/*
 * Name: Aidan Linerud
 * Date: 10/18/2023
 * Assignment: Wednesday Demo
 */

namespace WednesdayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            BaseClass bc = new BaseClass(123, 456);
            ChildClass cc = new ChildClass(78, 90);

            bc.SomeMethod();
            cc.SomeMethod();

            BaseClass[] bcArray = new BaseClass[] { bc, cc };

            foreach (BaseClass element in bcArray)
            {
                element.SomeMethod();
            }
        }
    }
}
