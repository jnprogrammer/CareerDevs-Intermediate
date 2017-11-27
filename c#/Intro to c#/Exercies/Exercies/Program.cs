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
            int[] ary = new int[100];
            
            Console.WriteLine("Enter a series of numbers seporated by a comma \",\"");
            var input = Console.ReadLine();
            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach(var num in numbers)
            {
                var number = Convert.ToInt32(num);
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("The max is " + max);
        }
    }
}
