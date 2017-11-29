using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
