namespace VirtualOverride
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("Max", 12);
            Console.WriteLine($"{dog.Name} is {dog.Age}");
            dog.Play();
            dog.MakeSound();
        }
    }
}