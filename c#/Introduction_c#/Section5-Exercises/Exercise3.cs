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
            Console.WriteLine("Enter the Width");
            string userInput = Console.ReadLine();
            int Width = Convert.ToInt32(userInput);

            Console.WriteLine("Enter the Height");
            userInput = Console.ReadLine();
            int Height = Convert.ToInt32(userInput);

            if (Width > Height)
            {
                Console.WriteLine("This image is landscape");
            }
            else
            {
                Console.WriteLine("This image is portrait");
            }
        }
    }
}
