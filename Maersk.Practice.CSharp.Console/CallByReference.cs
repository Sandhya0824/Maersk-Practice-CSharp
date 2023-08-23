using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class CallByReference
    {
        public void Demo(ref int message)
        {
            message = 2;
        }

        static void Main(string[] args)
        {
            int message = 10;
            Console.WriteLine(message);
            CallByReference callByReference = new CallByReference();
            callByReference.Demo(ref message);
            Console.WriteLine("I am " + message +" years old.");
        }

    }
}
