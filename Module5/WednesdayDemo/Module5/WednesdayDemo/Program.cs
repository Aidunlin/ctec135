/*
 * Name: Aidan Linerud
 * Date: 10/25/2023
 * Assignment: Wednesday Demo
 */

namespace WednesdayDemo
{
    class Student
    {
        public string Name { get; set; }
        public Student(string name) { Name = name; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            #region Stack

            Console.WriteLine("Demo Stack<T>");

            // declare/define
            Stack<Student> students = new Stack<Student>();

            // initialize
            students.Push(new Student("Adam"));
            students.Push(new Student("Bob"));
            students.Push(new Student("Jack"));

            // access
            Console.WriteLine("\taccess using Peek()");
            Console.WriteLine($"\t\t{students.Peek().Name}");

            // traversal
            Console.WriteLine("\ttraversal");
            foreach (Student student in students)
            {
                Console.WriteLine("\t\t" + student.Name);
            }

            // misc
            Console.WriteLine("\tdemo ToArray()");
            Student[] studentsArray = students.ToArray();
            foreach (Student student in studentsArray)
            {
                Console.WriteLine($"\t\t{student.Name}");
            }

            #endregion

            Console.WriteLine();

            #region Queue

            Console.WriteLine("Demo Queue<T>");

            // declare/define
            Queue<Student> studentQueue = new Queue<Student>();

            // initialize
            studentQueue.Enqueue(new Student("Adam"));
            studentQueue.Enqueue(new Student("Bob"));
            studentQueue.Enqueue(new Student("Jack"));

            // access
            Console.WriteLine("\taccess using Peek()");
            Console.WriteLine($"\t\t{studentQueue.Peek().Name}");
            Console.WriteLine();

            // traversal
            Console.WriteLine("\ttraversal");
            foreach (Student student in studentQueue)
            {
                Console.WriteLine("\t\t" + student.Name);
            }

            #endregion

            Console.WriteLine();

            #region Dictionary

            Console.WriteLine("demo Dictionary<TKey, TValue>");

            // declare/define using "var" keyword
            var studentDictionary = new Dictionary<string, Student>();

            // initialize
            studentDictionary.Add("Adam", new Student("Adam"));
            studentDictionary["Bob"] = new Student("Bob");
            studentDictionary["Jack"] = new Student("Jack");

            // access
            Console.WriteLine("\tdemo access");
            Console.WriteLine($"\t\texisting item: {studentDictionary["Adam"].Name}");
            if (studentDictionary.TryGetValue("Bruce", out Student? s))
                Console.WriteLine($"\t\texisting item: {s.Name}");
            else
                Console.WriteLine("\t\tBruce is not in dictionary");

            // traversal
            Console.WriteLine("\ttraversal");
            Console.WriteLine("\t\tprint keys");
            foreach (string key in studentDictionary.Keys)
            {
                Console.WriteLine($"\t\t\t{key}\t{studentDictionary[key].Name}");
            }

            Console.WriteLine("\t\tprint values");
            foreach (Student st in studentDictionary.Values)
                Console.WriteLine($"\t\t\t{st.Name}");
            Console.WriteLine();

            // modify - insert - remove
            Console.WriteLine("\tdemo modify and remove");

            // modify
            studentDictionary["Bill"] = new Student("William Baker");

            // remove
            studentDictionary.Remove("Jack");
            Console.WriteLine("\t\tprint keys");
            foreach (string key in studentDictionary.Keys)
                Console.WriteLine($"\t\t\t{key}");
            Console.WriteLine();
            Console.WriteLine("\t\tprint values");
            foreach (Student student in studentDictionary.Values)
                Console.WriteLine($"\t\t\t{student.Name}");
            Console.WriteLine();

            #endregion

            Console.WriteLine();

            #region Linked List

            Console.WriteLine("demo linked list");

            // create node
            LinkedListNode<string> lln = new LinkedListNode<string>("orange");

            Console.WriteLine("\tAfter creating node");
            DisplayProperties(lln);

            // create list
            LinkedList<string> ll = new LinkedList<string>();

            // initialize
            ll.AddLast(lln);

            Console.WriteLine("\tAfter adding node");
            DisplayProperties(lln);

            ll.AddFirst("red");
            ll.AddLast("yellow");

            Console.WriteLine("\tAfter adding red and yellow");
            DisplayProperties(lln);

            // traversal
            Console.WriteLine("\ttraversal");
            LinkedListNode<string>? node = ll.First;
            while (node != null)
            {
                Console.WriteLine($"\t\t{node.Value}");
                node = node.Next;
            }
            Console.WriteLine();

            // modify - insert - remove
            Console.WriteLine("\tdemo insertion");

            // insert
            node = ll.Find("orange");
            ll.AddBefore(node, new LinkedListNode<string>("Before"));
            ll.AddAfter(node, new LinkedListNode<string>("After"));
            Console.WriteLine("\tTraversal of linked list after insertions");
            node = ll.First;
            while (node != null)
            {
                Console.WriteLine("\t\t{0}", node.Value);
                node = node.Next;
            }

            #endregion

            Console.WriteLine();
        }

        public static void DisplayProperties(LinkedListNode<string> lln)
        {

            if (lln.List == null)
                Console.WriteLine("\t\tNode is not linked.");
            else
                Console.WriteLine("\t\tNode belongs to a linked list with " +
                    "{0} elements.", lln.List.Count);
            if (lln.Previous == null)
                Console.WriteLine("\t\tPrevious node is null.");
            else
                Console.WriteLine("\t\tValue of previous node: {0}",
                    lln.Previous.Value);

            Console.WriteLine("\t\tValue of current node:  {0}", lln.Value);

            if (lln.Next == null)
                Console.WriteLine("\t\tNext node is null.");
            else
                Console.WriteLine("\t\tValue of next node:     {0}",
                    lln.Next.Value);

            Console.WriteLine();
        }
    }

}
