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
            int numberTotals = 0, numbers = 0;
            do
            {
                Console.WriteLine("Enter a number or type \"ok\"");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out numbers))
                {
                    numberTotals += numbers;
                    Console.WriteLine(numberTotals);
                }

            } while (userInput != "ok");
        }
    }
}
