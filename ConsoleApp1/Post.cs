using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDateTime { get; }
        public int Votes { get; private set; }
        public Post(string title,string discription)
        {
            Title = title;
            Description = discription;
            CreationDateTime = DateTime.Now;
            Votes = 0;
            
        }
        public void UpVote()
        {
            Votes++;

        }
        public void Downvote()
        {
            Votes--;
            if(Votes<0)
            {
                Votes = 0;
            }
            
        }
    }
}
