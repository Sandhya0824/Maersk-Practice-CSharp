using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class MultithreadingAndSleep
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 started with " + Thread.CurrentThread.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method1 " + i);
            }
            Console.WriteLine("Method1 ended with " + Thread.CurrentThread.Name);
        }
        public static void Method2()
        {
            Console.WriteLine("Method2 started with " + Thread.CurrentThread.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method2 " + i);
                if (i == 2)
                {
                    Console.WriteLine("Database/IO operation started");
                    Thread.Sleep(5000);
                    Console.WriteLine("Database/IO operation ended");
                }
            }
            Console.WriteLine("Method2 ended with " + Thread.CurrentThread.Name);
        }
        public static void Method3()
        {
            Console.WriteLine("Method3 sarted with " + Thread.CurrentThread.Name);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method3 " + i);
            }
            Console.WriteLine("Method3 ended with " + Thread.CurrentThread.Name);
        }

        public static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Method1));
            t1.Name = "Thread1";
            Thread t2 = new Thread(new ThreadStart(Method2));
            t2.Name = "Thread2";
            Thread t3 = new Thread(new ThreadStart(Method3));
            t3.Name = "Thread3";

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
