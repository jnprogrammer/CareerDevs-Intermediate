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
            var numbers = new List<int>() { 50, 28, 73, 44 };
            numbers.Add(18);
            numbers.AddRange(new int[7] { 5, 6, 2, 7, 32, 34, 32 });

            foreach (var number in numbers)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("Index of 28: " + numbers.IndexOf(28));
            Console.WriteLine("Last Index of 2: " + numbers.LastIndexOf(2));
            Console.WriteLine("Count: " + numbers.Count);



            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 32)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
                Console.WriteLine(number);

            numbers.Clear();

            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
