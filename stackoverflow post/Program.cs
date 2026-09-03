using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_post
{


    public class Post
    {
       
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private int _voteCount;

       
        public Post(string title, string description)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            _voteCount = 0;
        }

        
        public void UpVote()
        {
            _voteCount++;
        }

        public void DownVote()
        {
            _voteCount--;
        }

        public int GetCurrentVote()
        {
            return _voteCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Post stackOverFlowPost = new Post("C# Basic", "Understanding encapsulation in OOP");

            do
            {
                Console.WriteLine(stackOverFlowPost.Title);
                Console.WriteLine(stackOverFlowPost.Description);
                Console.WriteLine(stackOverFlowPost.CreatedAt);
                Console.WriteLine("Current Votes: " + stackOverFlowPost.GetCurrentVote());

                Console.WriteLine("Up Vote press 1");
                Console.WriteLine("Down Vote press 2");
                Console.WriteLine("Exit press any other key");

                var s = Console.ReadLine();
                int x;
                if (int.TryParse(s, out x))
                {
                    if (x == 1)
                    {
                        stackOverFlowPost.UpVote();
                    }
                    else if (x == 2)
                    {
                        stackOverFlowPost.DownVote();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }

                Console.Clear();
            }
            while (true);
        }
    }

}