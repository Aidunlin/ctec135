/*
 * Name: Aidan Linerud
 * Date: 10/16/2023
 * Assignment: Monday Demo
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo1
{
    public class Base
    {
        protected int baseInt;

        public Base(int baseInt)
        {
            this.baseInt = baseInt;
        }

        public void baseMethod()
        {
            Console.WriteLine("baseMethod");
        }
    }

    public class Child : Base
    {
        protected int childInt;

        public Child(int baseInt, int childInt) : base(baseInt)
        {
            this.childInt = childInt;
        }

        public void childMethod()
        {
            Console.WriteLine("childMethod");
        }
    }

    public class GrandChild : Child
    {
        protected int gcInt;

        public GrandChild(int baseInt, int childInt, int gcInt) : base(baseInt, childInt)
        {
            this.gcInt = gcInt;
        }

        public void GCMethod()
        {
            Console.WriteLine("GCMethod");
        }

        public void PrintState()
        {
            Console.WriteLine($"base: {baseInt}");
            Console.WriteLine($"child: {childInt}");
            Console.WriteLine($"gc: {gcInt}");
        }
    }
}