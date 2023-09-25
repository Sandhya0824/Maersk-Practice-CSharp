using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.FileIO
{
    internal class StreamReaderExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Dev\\FileExample\\ex4.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();


            FileStream f1 = new FileStream("C:\\Dev\\FileExample\\ex2.txt", FileMode.OpenOrCreate);
            StreamReader s1 = new StreamReader(f1);

            string line1 = "";
            while ((line = s1.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            s1.Close();
            f1.Close();
        }
    }
}
