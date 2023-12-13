/*
 * Author: Aidan Linerud
 * Date: 10/9/2023
 * Assignment: Intro to Classes
 */

namespace Unit2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create a new object
            MyClass myObject = new MyClass();

            // use object
            myObject.Hello();
            Console.WriteLine(myObject.ToString());
        }
    }
}