﻿using System;
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


            // Program attepts to run code with in try block
            // If unable it will run code in catch block
            try
            {
                string str = "true";
                bool boolus = Convert.ToBoolean(str);
                Console.WriteLine(boolus);

                var num = "1234";
                int l = Convert.ToByte(num);
                Console.WriteLine(l);
            }
            catch (Exception)
            {

                Console.WriteLine("The number couldn't be converted to a byte");
            }
           

        }
    }
}
