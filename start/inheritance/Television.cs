using System;

namespace InheritanceDemo
{
    class TV : ElectricDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {
        }

        public void WatchTV()
        {

            if (IsOn)
                Console.WriteLine($"Listening to TV");
            else
                Console.WriteLine($"Turn on the TV to listen to TV.");
        }
    }
}