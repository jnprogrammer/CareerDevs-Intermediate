using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 6.4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
 The list of numbers may include duplicates. Display the unique numbers that the user has entered.
 * 
 */
namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = new List<int>();
            var input = "";
            int number = 0;

            do
            {
                Console.WriteLine("Enter a number or type quit");
                input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    numList.Add(number);
                }

            } while (input != "quit"  || input != "QUIT");

            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine("Number, " + numList[i]);
            }
        }
    }
}
