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
            var userInput = "";
            int convertedInput = 0, factorial = 1;
            Console.WriteLine("Enter a number, must be a number");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out convertedInput);

            for (int i = convertedInput; i >= 1; i--)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);



        }
    }
}
