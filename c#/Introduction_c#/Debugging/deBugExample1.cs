using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 
 * 
 This program intended use is to explore the debugging features of Visual Studio  
 * 
 * 
 * 
 */

namespace Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallest = GetSmallests(numbers, 3);

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallests(list);
                smallests.Add(min);
                list.Remove(min);
            }
            return smallests;
        }

        public static int GetSmallests(List<int> list)
        {
            //Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;
        }
    }
}
