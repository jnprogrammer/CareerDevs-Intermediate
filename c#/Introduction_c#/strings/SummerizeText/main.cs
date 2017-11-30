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
            var sentence = "This is a silly long text that is to long to be a correct sized sentence";
            var summary = stringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }
    }
}
