using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.FileIO
{
    internal class TextReaderExample
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("C:\\Dev\\FileExample\\ex5.txt"))
            {
                Console.WriteLine(tr.ReadToEnd());
            }

            using (TextReader tr = File.OpenText("C:\\Dev\\FileExample\\ex5.txt"))
            {
                Console.WriteLine(tr.ReadLine());
            }
        }
    }
}
