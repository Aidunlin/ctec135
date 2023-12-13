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

namespace InterfaceDemo
{
    internal class Class1 : ICloneable
    {
        public object Clone()
        {
            return new Class1();
        }
    }
}
