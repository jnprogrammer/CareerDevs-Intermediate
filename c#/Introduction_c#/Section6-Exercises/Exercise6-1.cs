using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 1- When you post a message on Facebook, depending on the number of people who like your post,
 Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
Depending on the number of names provided, display a message based on the above pattern.
 * 
 */
namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            var names = new List<string>();
            Console.WriteLine("Enter in names");

            do
            {
                name = Console.ReadLine();
                if (name != "")
                {
                    names.Add(name);
                }

            } while (name != "");

            var numNames = names.Count();

            switch (numNames)
            {
                case 0:
                    Console.WriteLine("No one likes your post");
                    break;
                case 1:
                    Console.WriteLine(string.Format("Hey {0} likes your post", names[0]));
                    break;
                case 2:
                    Console.WriteLine(string.Format("{0} and {1} likes your post", names[0], names[1]));
                    break;
                default:
                    Console.WriteLine(string.Format("Not only does {0}, {1} and {2} like your post, but others do too!", names[0], names[1], names[2]));
                    break;
            }
        }
    }
}
