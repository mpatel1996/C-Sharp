namespace HashDict
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Hash table demo
            /*
            #region 
            Hashtable studentsTable = new Hashtable();
            Student st1 = new Student(1, "Mary", 39);
            Student st2 = new Student(2, "Larry", 329);
            Student st3 = new Student(3, "Cherry", 339);
            Student st4 = new Student(4, "Sherry", 349);

            studentsTable.Add(st1.Id, st1);
            studentsTable.Add(st2.Id, st2);
            studentsTable.Add(st3.Id, st3);
            studentsTable.Add(st4.Id, st4);


            // Getting individual based on students ID which is known.
            Student sft1 = (Student)studentsTable[st1.Id];
            Console.WriteLine($"Student Id {sft1.Id}, Name is {sft1.Name} and GPA is {sft1.GPA}");

            // retrieve all values from hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine($"Student ID: {temp.Id}");
                Console.WriteLine($"Student Name: {temp.Name}");
                Console.WriteLine($"Student GPA: {temp.GPA}");
            }
            Console.WriteLine($"\n");

            foreach (Student temp in studentsTable.Values)
            {
                Console.WriteLine($"Student ID: {temp.Id}");
                Console.WriteLine($"Student Name: {temp.Name}");
                Console.WriteLine($"Student GPA: {temp.GPA}");
            }
            #endregion
            */

            // Dict Demo
            #region 
            Employee[] emps = {
                new Employee("CEO", "Mark", 59, 200),
                new Employee("COO", "Maurice", 49, 30),
                new Employee("CTO", "Matt", 39, 25),
                new Employee("CFO", "Matthew", 29, 20),
                new Employee("CSO", "Mardock", 39, 23),
            };

            Dictionary<string, Employee> empDict = new Dictionary<string, Employee>();

            foreach (Employee emp in emps)
            {
                empDict.Add(emp.Role, emp);
            }

            // Method 1 of getting values
            if (empDict.ContainsKey("CEO"))
            {
                Employee emp1 = empDict["CEO"];
                Console.WriteLine($"{emp1.Name} and ${emp1.Salary}");
            }

            // Method 2 of getting values based on Key

            Employee result;
            if (empDict.TryGetValue("CRO", out result))
            {
                Console.WriteLine($"Values received");
                Console.WriteLine($"{result.Name}");
            }

            #endregion
        }
    }
}