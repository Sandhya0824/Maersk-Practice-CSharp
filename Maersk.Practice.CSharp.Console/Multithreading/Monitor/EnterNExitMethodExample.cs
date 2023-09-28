using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Maersk.Practice.CSharp.Console.Multithreading.Monitor
{
    public class EnterNExitMethodExample
    {
        private static readonly object lockPrintNumberst = new object();
        public static void PrintNumbers()
        {
            System.Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter into the critical section");
            bool IsLockTaken = false;

            try
            {
                //Monitor.Enter(lockObject, ref IslockTaken) Method
                Monitor.Enter(lockPrintNumberst, ref IsLockTaken);
                if (IsLockTaken)
                {
                    System.Console.WriteLine(Thread.CurrentThread.Name + " Entered into the critical section");
                    for (int i = 0; i < 5; i++)
                    {
                        Thread.Sleep(100);
                        System.Console.Write(i + ",");
                    }
                    System.Console.WriteLine();
                }
            }
            finally
            {
                if (IsLockTaken)
                {
                    Monitor.Exit(lockPrintNumberst);
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
