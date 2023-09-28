using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class ThreadingExample
    {
        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("*" + i + "*");
            }
        }

        public static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(ThreadingExample.Method1));
            Thread t2 = new Thread(new ThreadStart(ThreadingExample.Method1));
            t1.Start();
            t2.Start();
            Console.WriteLine();

            ThreadingExample threadingExample = new ThreadingExample();
            Thread t3 = new Thread(new ThreadStart(threadingExample.Method2));
            Thread t4 = new Thread(new ThreadStart(threadingExample.Method2));
            t3.Start();
            t4.Start();
            Console.WriteLine();

            ThreadingExample threadingExample2 = new ThreadingExample();
            Thread t5 = new Thread(new ThreadStart(ThreadingExample.Method1));
            Thread t6 = new Thread(new ThreadStart(threadingExample2.Method2));
            t5.Start();
            t6.Start();
        }

    }
}
