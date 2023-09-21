using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class CallByValue
    {
        public void Demo(int intro)
        {
            intro *= 2;
        }

        static void Main(string[] args) 
        {
            CallByValue callByValue = new CallByValue();
            int intro = 10;
            Console.WriteLine(intro); ;
            callByValue.Demo(intro);
            Console.WriteLine("I am " + intro + " years old.");
        }

    }

}
