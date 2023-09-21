using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class OutParameter
    {
        public void Demo(out int message)
        {
            message = 2;
        }

        static void Main(string[] args)
        {
            int message;
            OutParameter outParameter = new OutParameter();
            outParameter.Demo(out message);
            Console.WriteLine("I am " + message + " years old.");
        }
    }
}
