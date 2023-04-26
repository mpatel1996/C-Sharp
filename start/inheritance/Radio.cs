using System;

namespace InheritanceDemo
{

    // Child class 
    class Radio : ElectricDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void ListenRadio()
        {

            if (IsOn)
                Console.WriteLine($"Listening to radio");
            else
                Console.WriteLine($"Turn on the radio to listen to radio.");
        }
    }
}