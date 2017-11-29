using System;
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
            string reverseName = "", input = "";
            Console.WriteLine("Enter your name please");
            input = Console.ReadLine();
            var nameAry = new char[input.Length];

            for (var i = 0; i < input.Length; i++)
            {
                nameAry[input.Length - 1] = nameAry[i + 1];
            }
            var strAry = new string(nameAry);
            Console.WriteLine(string.Format("{0}", nameAry));
        }
    }
}
