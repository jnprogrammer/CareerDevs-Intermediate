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
            Console.WriteLine("Enter the speed limit");
            string userInput = Console.ReadLine();
            int speedLimit = Convert.ToInt32(userInput);

            Console.WriteLine("Enter the Cars' speed");
            userInput = Console.ReadLine();
            int carSpeed = Convert.ToInt32(userInput);


            int speedOver, demeritPoints;
            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Okay, keep obaying the law");
            }
            else
            {
                //excess Speed must be modulus by 5 to find the amount of points to demerit.
                speedOver = carSpeed - speedLimit;
                if (speedOver > speedLimit)
                {
                    demeritPoints = speedOver / 5;
                    if (demeritPoints > 12)
                    {
                        Console.WriteLine("License Suspended");
                    }
                }


            }
        }
    }
}
