using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            bool loopBreaker = true;

            while (loopBreaker)
            {
                Console.WriteLine("Welcome to StackOverflow \n 1.Create Post \n 2.Upvote \n 3.Downvote \n 4.View Total votes \n 5.View Post \n 6.Exit");
                var keyPressed = Console.ReadLine();

                switch (keyPressed)
                {
                    case "1":
                        post.CreatePost();
                        break;
                    case "2":
                        post.Upvote();
                        break;
                    case "3":
                        post.DownVote();
                        break;
                    case "4":
                        int value = post.CurrentVotes;
                        Console.WriteLine("Current Votes: " + value);

                        break;
                    case "5":
                        post.ViewPost();
                        break;
                    case "6":
                        loopBreaker = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection. Retry!");
                        break;

                }
            }
        }
    }


    public class Post
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public string PostCreatedOn { get; set; }

        private int Upvotes;
        private int Downvotes;

        public int CurrentVotes { get { return Upvotes - Downvotes; } }


        public void CreatePost()
        {

            Console.WriteLine("\nType your post's TITLE and Press Enter");
            Title = Console.ReadLine();
            Console.WriteLine("\nType your post's DESCRIPTION and Press Enter");
            Description = Console.ReadLine();
            PostCreatedOn = DateTime.Now.ToString("dd:MM:yy HH:mm");
            Console.WriteLine("Post created successfully");
            Console.Clear();
        }
        public void Upvote()
        {
            Upvotes++;
            Console.WriteLine("\n Upvote Successful");

        }

        public void DownVote()
        {

            Downvotes++;
            Console.WriteLine("\n Downvote Successful");
        }



        public void ViewPost()
        {
            Console.WriteLine(" Title: " + Title + "\n Desciption: " + "Upvotes: " + Upvotes +
                "\t Downvotes" + Downvotes + "\t Total Votes: " + CurrentVotes + "\n Post created on:" + PostCreatedOn);

        }






    }
}
