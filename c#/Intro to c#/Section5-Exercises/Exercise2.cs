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
            Console.WriteLine("Enter a number");
            string userInput = Console.ReadLine();
            int convertedInput1 = Convert.ToInt32(userInput);

            Console.WriteLine("Enter another number");
            userInput = Console.ReadLine();
            int convertedInput2 = Convert.ToInt32(userInput);

            if (convertedInput1 > convertedInput2)
            {
                Console.WriteLine("Largest Number: " + convertedInput1);
            }
            else
            {
                Console.WriteLine("Largest Number: " + convertedInput2);
            }
        }
    }
}
