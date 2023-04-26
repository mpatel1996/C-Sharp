namespace inheritancePostDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the lunch", true, "MihirP");
            Console.WriteLine(post1.ToString());

            ImagePost imgPost = new ImagePost("Check out my shot", "MihirP", "home/pics/", true);
            Console.WriteLine($"{imgPost.ToString()}");

            VideoPost vdPost = new VideoPost("My first Vidseo", "MihirP", "google.com/firstVideo/", 5, true);
            Console.WriteLine($"{vdPost.ToString()}");
            vdPost.Play();
            Console.WriteLine($"Press any key to stop Video");
            Console.ReadKey();
            vdPost.Stop();
            post1.Update("Updated Title", true);
            Console.WriteLine(post1.ToString());
        }
    }
}
