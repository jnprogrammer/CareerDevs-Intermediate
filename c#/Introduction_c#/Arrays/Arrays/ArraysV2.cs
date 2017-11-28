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
            var numsArray = new[] { 3, 7, 9, 2, 14, 6 };

            //Length
            Console.WriteLine("Length: " + numsArray.Length);

            //IndexOf()
            var index = Array.IndexOf(numsArray, 9);
            Console.WriteLine("The index of 9 " + index);

            //Clear
            Array.Clear(numsArray, 0, 2);
            Console.WriteLine("Effect of Clear()");
            foreach (var n in numsArray)
                Console.WriteLine(n);
            //Copy()
            int[] secondArray = new int[6];
            Array.Copy(numsArray, secondArray, 4);

            Console.WriteLine("The effect of Copy()");
            foreach (var n in secondArray)
            {
                Console.WriteLine(n);
            }

            //sort()

            Array.Sort(numsArray);
            Console.WriteLine("The effect of sort()");
            foreach (var n in numsArray)
                Console.WriteLine(n);

            //Reverse()

            Array.Reverse(numsArray);
            Console.WriteLine("The effect of Reverse");
            foreach (var n in numsArray)
                Console.WriteLine(n);
        }
    }
}
