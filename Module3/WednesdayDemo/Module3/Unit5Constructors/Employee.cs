using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit5Constructors
{
    public class Employee
    {
        #region Fields & Properties

        private string employeeName;
        public string Name
        {
            get { return employeeName; }
            set
            {
                if (value.Length > 15)
                {
                    employeeName = value.Substring(0, 15);
                }
                else
                {
                    employeeName = value;
                }
            }
        }

        // auto properties
        public int ID { get; set; }
        public double Pay { get; set; }

        #endregion

        #region Constructors

        // primary constructor
        public Employee(string name, int id, double pay)
        {
            Name = name;
            ID = id;
            Pay = pay;
        }

        public Employee() : this("", 0, 0) { }

        #endregion

        public void PrintState()
        {
            Console.WriteLine($"Name:\t{Name}");
            Console.WriteLine($"ID:\t{ID}");
            Console.WriteLine($"Pay:\t{Pay}\n");
        }
    }
}
