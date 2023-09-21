using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.FileIO
{
    internal class StreamWriterExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Dev\\FileExample\\ex4.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("Hello I am Sandhya.");
            s.Close();
            f.Close();
            Console.WriteLine("File created successfully...");
        }
    }
}
