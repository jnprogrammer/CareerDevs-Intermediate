using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Exercise 2: Design a StackOverﬂow Post Design a class called Post. 

This class models a StackOverﬂow post. It should have properties for title, description and the date/time it was created.
We should be able to up-vote or down-vote a post.
We should also be able to see the current vote value. In the main method, create a post, 
up-vote and down-vote it a few times and then display the the current vote value. 

In this exercise, you will learn that a StackOverﬂow post should provide methods for up-voting and down-voting. 
You should not give the ability to set the Vote property from the outside, because otherwise, 
you may accidentally change the votes of a class to 0 or to a random number.
And this is how we create bugs in our programs.
The class should always protect its state and hide its implementation detail. 
 */

namespace Intermediate_Exercies
{
    public class Post
    {
        public string title;
        public string description;
        public DateTime dateCreated;

        public Post()
        {
            Console.WriteLine("post object created");
        }
        private int votes;

        public int theVotes
        {
            get
            {
                return votes;
            }
            set
            {
                votes = value;
            }
        }

        public void DownVote()
        {
            votes--;
            Console.WriteLine("Post DownVoted :(");
            Console.WriteLine("UpVotes reamining: " + votes + "\n");
        }

        public void UpVote()
        {
            votes++;
            Console.WriteLine("UpVotes remaining: " + votes + "\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var stackOverflowPost = new Post();

            stackOverflowPost.theVotes = 24;

            do
            {
                i++;
                stackOverflowPost.DownVote();
            } while (i <= 10);

        }
    }
}
