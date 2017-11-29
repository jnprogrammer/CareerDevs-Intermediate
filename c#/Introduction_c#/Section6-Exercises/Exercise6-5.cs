using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 6.5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
 If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
 otherwise, display the 3 smallest numbers in the list.
 * 
 * WORK IN PROGESS
 */
namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            var numList = new List<int>();
            Console.WriteLine("Enter a list of comma separated numbers");
            input = Console.ReadLine();
            var strNums = input.Split(',');
            if (strNums.Length < 5)
            {
                Console.WriteLine("Invalid List, Please Retry");
            }




        }
    }
}
