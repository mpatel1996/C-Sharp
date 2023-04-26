using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inheritancePostDemo
{
    class ImagePost : Post
    {
        public string ImgURL { get; set; }

        public ImagePost() { }
        public ImagePost(string title, string sendbyUsername, string imgURl, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendbyUsername = sendbyUsername;
            this.IsPublic = isPublic;
            this.ImgURL = imgURl;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImgURL} - by {this.SendbyUsername}");
        }
    }
}