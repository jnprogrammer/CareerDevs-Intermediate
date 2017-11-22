using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int convertedInput = Convert.ToInt32(userInput);
            if(convertedInput <= 10 && convertedInput >= 1)
            {
                Console.WriteLine("Valid Input");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
