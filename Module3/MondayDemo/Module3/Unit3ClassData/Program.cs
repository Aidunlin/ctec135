/*
 * Author: Aidan Linerud
 * Date: 10/9/2023
 * Assignment: Class Data
 */

namespace Unit3ClassData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            DemoClass demoObject = new DemoClass();

            // example of traditional getter/setter
            demoObject.SetTraditionalField("some text");
            Console.WriteLine("Traditional Field Test");
            Console.WriteLine($"\t{demoObject.GetTraditionalField()}\n");

            // example of property use
            demoObject.PropertyField = "property string value";
            Console.WriteLine($"\t{demoObject.PropertyField}\n");

            // example of auto property
            demoObject.AutoProperty = "auto property value";
            Console.WriteLine($"\t{demoObject.AutoProperty}\n");
        }
    }
}