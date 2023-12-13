/*
 * Author: Aidan Linerud
 * Date: 10/11/2023
 * Assignment: PA03
 */

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intentionally cause an error and catch it

            try
            {
                CauseError(10);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error occurred");
            }
        }

        static int CauseError(int x)
        {
            return x / 0;
        }
    }
}