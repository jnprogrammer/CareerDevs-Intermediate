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
            var dateTime = new DateTime(2012, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            //  Console.WriteLine("Hour: " + now.Hour);
            //  Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(23);
            var lastWeek = now.AddDays(-32);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM"));
        }
    }
}
