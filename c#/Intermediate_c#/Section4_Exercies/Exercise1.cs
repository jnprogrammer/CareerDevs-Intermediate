using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Intermediate_Exercies
{

    public class Stack
    {
        List<object> stackList = new List<object>();

        public void Push(object obj)
        {
            stackList.Add((object)obj);
        }

        public object Pop(int index)
        {

            Console.WriteLine(stackList[0]);
            return stackList.Remove(stackList[0]);
        }

        public void clear()
        {
            stackList.Clear();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop(3);
            stack.Pop(2);
            stack.Pop(1);

        }
    }
}
