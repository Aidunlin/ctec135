/*
 * Name: Aidan Linerud
 * Date: 10/18/2023
 * Assignment: Wednesday Demo
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class AbstractClass
    {
        // fields

        // properties

        // methods

        // abstract method
        public abstract void CalculatePay();
    }

    public class ChildClass : AbstractClass
    {
        // implement abstract method
        public override void CalculatePay()
        {
            Console.WriteLine("Calculate pay");
        }
    }
}
