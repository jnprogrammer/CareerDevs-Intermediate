using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercies
{
    public class Car
    {
        public string Model;

        public void CarModel(string carColor)
        {
            Console.WriteLine("This car is a {0} {1}", Model, carColor);
        }

        public static Car Parse(string str)
        {
            var car = new Car();
            car.Model = str;
            return car;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var car = Car.Parse("Model S P200D");
            Console.WriteLine(car.Model);
            //var Tesla = new Car();
            //Tesla.Model = "Model S P200D";
            //Tesla.CarModel("Midnight Black");
        }
    }
}
