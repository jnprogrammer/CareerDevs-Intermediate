using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
              
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            byte number = 0;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "catty";
            bool isWorking = false;
            // type cw and press tab to use a code snippet for console.writeline
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

        }
    }
}
