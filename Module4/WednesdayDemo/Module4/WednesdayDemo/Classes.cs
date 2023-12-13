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

namespace WednesdayDemo
{
    /// <summary>
    /// Summary
    /// </summary>
    /// <remarks>Remarks</remarks>
    public class BaseClass
    {
        // fields
        private int myPrivateField;
        protected int myProtectedField;

        // constructor
        public BaseClass(int myPrivateField, int myProtectedField)
        {
            this.myPrivateField = myPrivateField;
            this.myProtectedField = myProtectedField;
        }

        // methods
        public virtual void SomeMethod()
        {
            Console.WriteLine("SomeMethod in BaseClass");
        }
    }

    public class ChildClass : BaseClass
    {
        // constructor
        public ChildClass(int myPrivateField, int myProtectedField)
            : base(myPrivateField, myProtectedField)
        {

        }

        // methods
        public override void SomeMethod()
        {
            Console.WriteLine("SomeMethod in ChildClass");
        }
    }
}
