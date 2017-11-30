using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('_', 32)
                   .AppendLine()
                   .Append("            Header")
                   .AppendLine()
                   .Append('_', 32)
                   .Replace('_', '-')
                   .Remove(0, 10)
                   .Insert(0, new string('-', 10));


            Console.WriteLine(builder);

            Console.WriteLine(builder[0]);
        }
    }
}
