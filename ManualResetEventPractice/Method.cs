using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualResetEventPractice
{
    public class Method : IMethod
    {
        public void Print()
        {
            Console.WriteLine("Starting 1");
            Program.autoResetEvent.WaitOne();
            Console.WriteLine("Finishing 1");

            Console.WriteLine();

            Console.WriteLine("Starting 2");
            Program.autoResetEvent.WaitOne();
            Console.WriteLine("Finishing 2");
        }
    }
}
