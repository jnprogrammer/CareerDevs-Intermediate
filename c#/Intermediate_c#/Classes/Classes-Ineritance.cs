using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Exercies
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vechicle is being initialized");
        //}

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("Vechicle is being initialized: {0}", registrationNumber);
        }
    }

    public class Car : Vehicle
    {
        public Car(string regNum)
            : base(regNum)
        {
            Console.WriteLine("Car is being initialized {0}", regNum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("XWFR42");
        }
    }
}
