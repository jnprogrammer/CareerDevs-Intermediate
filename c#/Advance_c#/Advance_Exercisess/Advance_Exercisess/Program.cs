using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Exercisess
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Boolean { ISBN = "121212", Title = "C# Advance" };
        }

    }

    public class GenericList<T>
    {
        public void add(T val)
        {

        }

        public T this[int index]
        {
            get { throw}
        }
    }
}