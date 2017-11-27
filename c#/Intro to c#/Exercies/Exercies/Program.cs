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
            var random = new Random();
            int tries = 4, randomNumber = 0, convertedNum=0;
            string userInput = "";
            bool win = false;
            Console.WriteLine("Pick a number between 1 and 10, guess right to win!");
            Console.WriteLine(String.Format("You have {0} tries", tries));
            randomNumber = 2; // random.Next(1, 10);

            do
            {
                userInput = Console.ReadLine();
                int.TryParse(userInput, out convertedNum);
                if (convertedNum != randomNumber)
                {
                    tries--;
                    Console.WriteLine("Wrong guess Try again");
                    Console.WriteLine(String.Format("You have {0} tries", tries));
                    if (tries <= 0)
                    {
                        Console.WriteLine("You lost");
                        break;
                    }
                }
                else if (convertedNum == randomNumber)
                {
                    Console.WriteLine("You guess right, you've won!");
                    win = true;
                    break;

                }
            } while (tries <= 0 || win == false);

        }
    }
}
