/*
 * Name: Aidan Linerud
 * Date: 10/11/2023
 * Assignment: Wednesday Demo
 */

namespace Unit7Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nHello");

            try
            {
                CauseException();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Source);
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.TargetSite);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void CauseException()
        {
            /*
            int y = 0;
            int x = 10 / y;
            */

            throw new InvalidOperationException("Some helpful text");
        }
    }
}