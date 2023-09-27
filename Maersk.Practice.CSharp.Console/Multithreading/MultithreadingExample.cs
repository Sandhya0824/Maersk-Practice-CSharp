using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Maersk.Practice.CSharp.Console.Multithreading
{
    public class MultithreadingExample
    {
        public class ThreadStaticMethodExample
        {
            public static void StaticMethodExample()
            {
                System.Console.WriteLine("\nThread Static Method Example");

                for (int i = 0; i < 10; i++)
                {
                    System.Console.Write(i +" ");
                }
                System.Console.WriteLine();
            }
        }
        public class ThreadNonStaticMethodExample
        {
            public void NonStaticMethodExample1()
            {
                System.Console.WriteLine("\nThread Non-Static Method Example1");

                for (int i = 0; i < 5; i++)
                {
                    System.Console.Write(i+" ");
                    Thread.Sleep(1000);
                }
                System.Console.WriteLine();

            }
            public void NonStaticMethodExample2()
            {
                System.Console.WriteLine("\nThread Non-Static Method Example2");

                for (int i = 5; i < 10; i++)
                {
                    System.Console.Write(i + " ");
                    Thread.Sleep(1000);
                }
                System.Console.WriteLine();

            }
        }
        public static void Main(string[] args)
        {
            //Main Thread example - The first thread which is created inside a process is called Main thread. It starts first and ends at last.
            //Naming Thread
            Thread thread = Thread.CurrentThread;
            thread.Name = "MainThread";
            System.Console.WriteLine(thread.Name+" is running");

            Thread thread1 = new Thread(new ThreadStart(ThreadStaticMethodExample.StaticMethodExample));
            Thread thread2 = new Thread(new ThreadStart(ThreadStaticMethodExample.StaticMethodExample));
            thread1.Start();
            thread1.Join();
            thread2.Priority = ThreadPriority.Normal;

            thread2.Start();
            thread2.Join();

            ThreadNonStaticMethodExample threadNonStaticMethodExample = new ThreadNonStaticMethodExample();
            Thread thread3 = new Thread(new ThreadStart(threadNonStaticMethodExample.NonStaticMethodExample1));
            Thread thread4 = new Thread(new ThreadStart(threadNonStaticMethodExample.NonStaticMethodExample2));

            thread4.Priority = ThreadPriority.Highest;
            thread3.Priority = ThreadPriority.Lowest;
            thread3.Start();
            thread3.Join();
            thread4.Start();
            thread4.Join();

            /*try
            {
                thread1.Abort();
                thread2.Abort();
            }
            catch (ThreadAbortException e)
            {
                System.Console.WriteLine(e.ToString());
            }
            System.Console.WriteLine("End of Main");*/
        }

    }
}
