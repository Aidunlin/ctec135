namespace ClassDemo
{
    internal class Student
    {
        // 2. Traditional field with getter/setter
        private string name;
        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }

        // 3. Field & property
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        // 4. Auto-property
        public int ID { get; set; }

        #region 5. Constructors

        // 5.A. Primary constructor
        public Student(string name, string address, int id)
        {
            this.name = name;
            Address = address;
            ID = id;
        }

        // 5.B. Constructor using chaining
        public Student(string name)
            : this(name, "", 0) { }

        // 5.C. Default constructor using chaining
        public Student()
            : this("", "", 0) { }
        
        #endregion

        // 6. Method creation
        public void PrintState()
        {
            Console.WriteLine("Student:");
            Console.WriteLine($"\tName:\t\t{name}");
            Console.WriteLine($"\tAddress:\t{address}");
            Console.WriteLine($"\tID:\t\t{ID}");
        }
    }
}