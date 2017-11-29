using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 6.3- Write a program and ask the user to enter 5 numbers. 
 If a number has been previously entered, display an error message and ask the user to re-try. 
 Once the user successfully enters 5 unique numbers, sort them and display the result on the console 
 * 
 */
namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var input = "";
            
            Console.WriteLine("Enter in 5 numbers larger than the last");
            do
            {
                input = Console.ReadLine();
                int.TryParse(input, out int convertedNum);

                if (!numbers.Contains(convertedNum))
                {
                    numbers.Add(convertedNum);
                }
                else
                {
                    Console.WriteLine("you must enter a unique number");
                }
            } while (numbers.Count < 5);

            numbers.Sort();
            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Numbers: " + numbers[i]);
            }
        }
    }
}
