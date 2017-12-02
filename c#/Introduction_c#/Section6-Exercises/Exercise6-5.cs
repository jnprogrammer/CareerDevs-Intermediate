using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 6.2- Write a program and ask the user to enter their name. 
 Use an array to reverse the name and then store the result in a new string. 
 Display the reversed name on the console.
 * 
 */

namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of CSV up to five numbers:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                        break;
                }
                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                smallests.Add(min);
                numbers.Remove(min);
            }
            Console.WriteLine("the 3 smallest numbers are: ");
            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }


    }
}
