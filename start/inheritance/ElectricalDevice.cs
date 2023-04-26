namespace InheritanceDemo
{
    // parent class
    class ElectricDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public ElectricDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }
    }
}