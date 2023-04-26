// See https://aka.ms/new-console-template for more information

namespace Classes__Basics
{
    class Box
    {
        // private int length;
        // private int height;
        // private int width;
        // private int volume;

        // Created using "prop" and Enter
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        // public int Height
        // {
        //     get
        //     {
        //         return height;
        //     }
        //     set
        //     {
        //         if () { stuff}
        //         height = value;
        //     }
        // }

        // public void SetLength(int length)
        // {
        //     this.length = length;
        // }
        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }

        public int GetLength()
        {
            return this.Length;
        }

        public int GetVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Length is {this.Length} \nheight is {this.Height} \nwidth is {this.Width} \nvolume is {GetVolume()}");

        }
    }
}

