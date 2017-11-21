using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversion
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //Explicit Type Conversion
            int r = 1;
            byte u = (byte)r;
            Console.WriteLine(u);


            var num = "1234";
            int l = Convert.ToInt32(num);
            Console.WriteLine(l);

        }
    }
}
