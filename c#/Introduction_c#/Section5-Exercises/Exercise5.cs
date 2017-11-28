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
            int counter = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    counter++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(string.Format("There are {0} numbers that are divisible by 3 with no remainder", counter));

        }
    }
}
