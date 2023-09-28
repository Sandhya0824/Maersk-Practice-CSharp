using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Maersk.Practice.CSharp.Console.Multithreading.Monitor
{
    public class TryEnterMethodExample
    {
        private static readonly object lockPrintNumbers = new object();
        public static void PrintNumbers()
        {
            TimeSpan timeout = TimeSpan.FromMilliseconds(1000);
            bool lockTaken = false;
            try
            {
                System.Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
                Monitor.TryEnter(lockPrintNumbers, timeout, ref lockTaken);
                if (lockTaken)
                {
                    System.Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(100);
                        System.Console.Write(i + ",");
                    }
                    System.Console.WriteLine();
                }
                else
                {
                    // The lock was not acquired.
                    System.Console.WriteLine(Thread.CurrentThread.Name + " Lock was not acquired");
                }
            }
            finally
            {
                // To Ensure that the lock is released.
                if (lockTaken)
                {
                    Monitor.Exit(lockPrintNumbers);
                    System.Console.WriteLine(Thread.CurrentThread.Name + " Exit from critical section");
                }
            }
        }

        public static void Main(string[] args)
        {
            Thread[] Threads = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                Threads[i] = new Thread(PrintNumbers)
                {
                    Name = "Child Thread " + i
                };
            }
            foreach (Thread t in Threads)
            {
                t.Start();
            }
            System.Console.ReadLine();
        }
    }
}*/
