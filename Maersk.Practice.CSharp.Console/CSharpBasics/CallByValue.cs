using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    internal class CallByValue
    {
        public int foo(int a)
        {
            a = 80;
            return a;
        }

        public static void Main(string[] args)
        {
            int x = 8;
            CallByValue obj2 = new CallByValue();
            System.Console.WriteLine("Value Before Call By Value: {0} ", x);

            obj2.foo(x);
            System.Console.WriteLine("Value After Call By Value: {0} ", x);
        }

    }
}
