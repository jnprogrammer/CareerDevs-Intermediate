using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Manny";
            string test1 = "ot";
            // String test2 = "Mot";
            var lastName = "Tmaoe";

            var FullName = firstName + " " + lastName;

            var myFullName = string.Format("My nameis {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mark" };
            var formattedNames = string.Join("_", names);
            //var formattedNames = string.Join("_$#_)))____", names);
            Console.WriteLine(formattedNames);
            var path = "Hi Josh look at your path here \nC:\\Users\\jnprogrammer2\\Documents\\Visual Studio 2017\\Code Snippets";
            var path2 = @"Hey Josh
Look at this following path
C:\Users\jnprogrammer2\Documents\Visual Studio 2017\Code Snippets";
        }
    }
}
