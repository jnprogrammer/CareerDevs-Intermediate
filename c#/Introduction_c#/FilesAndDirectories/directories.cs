using System;
using System.IO;
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
            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"C:\Users\jnprogrammer2\Documents\CareerDevs-Intermediate\c#\Introduction_c#", "*.cs", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                //Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\jnprogrammer2\Documents\CareerDevs-Intermediate\c#\Introduction_c#", "*.*",
                SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var directoryInfo = new DirectoryInfo("   ");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
