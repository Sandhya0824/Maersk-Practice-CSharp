using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    internal class CallByReference
    {
        public int foo(ref int x)   //ref keyword is used
        {
            x = 90;
            return x;
        }

        public static void Main(string[] args)
        {
            int a = 30;
            CallByReference obj1 = new CallByReference();
            System.Console.WriteLine("Value Before Call By Reference: {0} ", a);

            obj1.foo(ref a);
            System.Console.WriteLine("Value After Call By Reference: {0} ", a);
        }
    }
}
