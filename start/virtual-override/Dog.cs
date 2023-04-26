using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            this.IsHappy = true;
        }

        // simple override of the virtual Eat method
        public override void Eat()
        {
            // If we still want to call base Eat method, do is by following:
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Wuuuf Wuuf");
        }

        public override void Play()
        {
            if (IsHappy)
                base.Play();
        }
    }
}