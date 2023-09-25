using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.FileIO
{
    internal class TextWriterExample
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = File.CreateText("C:\\Dev\\FileExample\\ex5.txt"))
            {
                writer.WriteLine("Hello I am Sandhya");
                writer.WriteLine("I am an intern at Maersk");
            }
            Console.WriteLine("Data written successfully");
        }
    }
}
