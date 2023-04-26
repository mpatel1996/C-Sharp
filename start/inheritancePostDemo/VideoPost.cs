using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritancePostDemo
{
    class VideoPost : Post
    {

        // memebr fields
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;
        // Properties
        protected string VideoUrl { get; set; }
        protected int Length { get; set; }

        public VideoPost() { }
        public VideoPost(string title, string sendbyUsername, string videoUrl, int length, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendbyUsername = sendbyUsername;
            this.IsPublic = isPublic;


            this.VideoUrl = videoUrl;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine($"Playing");

                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }

        private void TimerCallback(Object o)
        {
            if (currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"video at {currentDuration} second");
                // force garbage colleciton
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Video Stopped at {currentDuration} seconds");
                currentDuration = 0;
                timer.Dispose();
            }

        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoUrl} - and length is {this.Length} - by {this.SendbyUsername}");
        }
    }
}