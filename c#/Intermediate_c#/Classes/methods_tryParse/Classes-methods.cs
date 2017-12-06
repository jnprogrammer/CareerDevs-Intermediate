using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Exercies
{
    class Program
    {
        static void Main(string[] args)
        {
            // var num = int.Parse("sdag");
            var BoolResult = int.TryParse("DSAf", out int result);
            if (BoolResult)
                Console.WriteLine(result);
            else
                Console.WriteLine("Conversion Faild");
        }

        static void UseParams()
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Add(1, 14, 34, 32, 53, 5, 431, 6));
            Console.WriteLine(calc.Add(1, 14, 31, 6));
            Console.WriteLine(calc.Add(1, 14, 245, 2));//easier to do.
            Console.WriteLine(calc.Add(new int[] { 1, 14, 31, 6 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
                point.Move(123, 42);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error happened");
            }
        }
    }
}
