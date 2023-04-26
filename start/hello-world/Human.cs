namespace Classes__Basics
{
    // blueprint for data type
    class Human
    {
        // member variable
        private string firstName;
        private string lastName;

        // constructor 
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // member methods
        public void Introduce()
        {
            System.Console.WriteLine($"Hi, I'm {firstName} {lastName}");
        }
    }
}