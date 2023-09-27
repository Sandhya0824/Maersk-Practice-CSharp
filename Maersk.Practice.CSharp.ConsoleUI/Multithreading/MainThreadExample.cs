using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class MainThreadExample
    {
        static void Method1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
                if (i == 2)
                {
                    Console.WriteLine("Performing the Database/IO Operation Started");
                    Thread.Sleep(5000);
                    Console.WriteLine("Performing the Database/IO Operation Completed");
                }
            }
        }
        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }

        public static void Main(string[] args)
        {
            Method1();
            Method2();
            Method3();
        }
    }
}
}
