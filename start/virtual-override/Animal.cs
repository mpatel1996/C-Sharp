namespace VirtualOverride
{
    class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.IsHungry = true;
        }

        public virtual void MakeSound()
        {

        }


        // a virtual method called Eat which sub classes can Override
        public virtual void Eat()
        {
            if (IsHungry)
                Console.WriteLine($"{Name} is eating");
            else
                Console.WriteLine($"{Name} is not hungry");
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }
    }
}