using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("Time to enjoy the Sun");
                    break;
                case Season.Winter:
                    Console.WriteLine("ITs winter");
                    break;
                case Season.Spring:
                    Console.WriteLine("ITs spring time");
                    break;
                default:
                    Console.WriteLine("I don't understand the season");
                    break;
            }
        }
    }
 //bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //    price = 19.95f;
            //else
            //    price = 29.95f;

            // Ternary Operator
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);
      //int hour = 10;

      //      if (hour > 0 && hour < 12)
      //      {
      //          Console.WriteLine("It's morning.");
      //      }
      //      else if (hour >= 12 && hour < 18)
      //      {
      //          Console.WriteLine("It's afternoon.");
      //      }
      //      else
      //      {
      //          Console.WriteLine("It's evening.");
      //      }

}


