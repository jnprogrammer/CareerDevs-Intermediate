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
 * WORK IN PROGRESS
 */

namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.WriteLine("Enter your name please");
            input = Console.ReadLine();


            var nameAry = new char[input.Length];

            for (var i = input.Length; i > 0; i--)
            {
                nameAry[input.Length - i] = nameAry[i - 1];
            }
            var strAry = new string(nameAry);
            Console.WriteLine("Reversed: " + strAry);
        }


    }
}
