/*
 * Name: Aidan Linerud
 * Date: 10/23/2023
 * Assignment: Monday Demo
 */

namespace MondayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region Arrays

            Console.WriteLine("Demo arrays");

            // declaration
            Student[] studentArray;
            
            // definition
            studentArray = new Student[3];

            // initialization
            for (int i = 0; i < studentArray.Length; i++)
                studentArray[i] = new Student($"Student{i}");

            // declaring/defining/initializing
            int[] a = { 1, 2, 3 };

            // access
            Console.WriteLine("\tdemo random eaccess");
            Console.WriteLine($"\t\t{studentArray[1].Name}");
            Console.WriteLine();

            // traversal
            Console.WriteLine("\tdemo traversal");
            foreach (Student student in studentArray)
                Console.WriteLine($"\t\t{student.Name}");

            // modification
            studentArray[1] = new Student("StudentX");

            // remove
            studentArray[0] = null;

            // traversal
            Console.WriteLine("\tdemo traversal null check");
            foreach (Student student in studentArray)
                if (student != null)
                    Console.WriteLine($"\t\t{student.Name}");

            #endregion

            Console.WriteLine();

            #region Lists

            Console.WriteLine("Demo lists<T>");

            // declare/define
            List<Student> studentList = new List<Student>();

            Console.WriteLine($"\tcapacity: {studentList.Capacity}");

            // initialize
            for (int i = 0; i < 4; i++)
                studentList.Add(new Student($"Student{i}"));

            // access
            Console.WriteLine("\tdemo random access");
            Console.WriteLine($"\t\t{studentList[1].Name}");
            Console.WriteLine();

            // traversal
            Console.WriteLine("\tdemo traversal");
            foreach (Student student in studentList)
                Console.WriteLine($"\t\t{student.Name}");
            Console.WriteLine();

            Console.WriteLine($"\tcapacity: {studentList.Capacity}");
            Console.WriteLine();

            // modify/insert/remove
            studentList[0] = new Student("StudentX");
            studentList.Insert(1, new Student("StudentY"));
            studentList.RemoveAt(studentList.Count - 1);

            Console.WriteLine("\tdemo traversal");
            foreach (Student student in studentList)
                Console.WriteLine($"\t\t{student.Name}");
            Console.WriteLine();

            #endregion
        }
    }

    public class Student
    {
        // property
        public string Name { get; set; }

        // cosntructor
        public Student(string name) { Name = name; }
    }
}
