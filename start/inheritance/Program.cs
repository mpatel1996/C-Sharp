namespace InheritanceDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            TV myTv = new TV(false, "LG");
            myTv.SwitchOn();
            myTv.WatchTV();

        }
    }
}
