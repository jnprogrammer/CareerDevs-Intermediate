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

            // Creating timespan objects
            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan2 = new TimeSpan(1, 0, 0);

            var timeSpan3 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(7)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(23)));

            //To string
            Console.WriteLine("ToString" + timeSpan);

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:12:23"));
        }
    }
}
