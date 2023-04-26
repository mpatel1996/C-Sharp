using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritancePostDemo
{
    class Post
    {
        // member fields
        private static int currentPostId;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendbyUsername { get; set; }
        protected bool IsPublic { get; set; }


        public Post()
        {
            ID = 0;
            Title = "My first post";
            IsPublic = true;
            SendbyUsername = "MihirPatel";
        }


        // Instance contructor with three parameters
        public Post(string title, bool isPublic, string sendbyUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendbyUsername = sendbyUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendbyUsername}");
        }
    }
}