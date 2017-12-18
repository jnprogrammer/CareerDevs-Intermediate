using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intermediate_Exercies
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }
        public string Name { get; set; }
        public string UserName { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1));
            Console.WriteLine(person.Age);

        }
    }
}
