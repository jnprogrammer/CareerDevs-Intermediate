using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Exercies
{

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
            StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList();
            list.Add(24);
            list.Add("BitCoin");

            var anotherList = new List<int>();
            //downcasting
            //Shape shape = new Text();
            //Text text = (Text)shape;
            //text.
        }
    }
}
