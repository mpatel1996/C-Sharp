namespace Classes__Basics
{
    class Members
    {
        private string mName;
        // private string jobTitle;
        private int salary;

        public int age;

        public string JobTitle { get; set; }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInto();
            }
            else
            {
                Console.WriteLine($"Hi, my Name is {this.mName} and my job title is {this.JobTitle}");

            }
        }

        private void SharingPrivateInto()
        {
            Console.WriteLine($"My Salary is {this.salary}");

        }

        public Members()
        {
            age = 30;
            mName = "Lucy";
            salary = 50000;
            JobTitle = "Developer";
            Console.WriteLine($"Object Created");

        }

        // finalizer - destructors 
        ~Members()
        {
            // cleanup statements
            Console.WriteLine($"Deconstructors of members object");
        }
    }
}