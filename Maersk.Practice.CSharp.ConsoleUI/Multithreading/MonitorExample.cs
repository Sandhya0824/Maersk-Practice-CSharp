using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class MonitorExample
    {
        const int numberLimit = 10;
        static readonly object _lockMonitor = new object();
        public static void Main(string[] args)
        {
            Thread EvenThread = new Thread(PrintEvenNumbers);
            Thread OddThread = new Thread(PrintOddNumbers);
            
            EvenThread.Start();
            Thread.Sleep(100);
            OddThread.Start();

            OddThread.Join();
            EvenThread.Join();
        }
        static void PrintEvenNumbers()
        {
            try
            {
                Monitor.Enter(_lockMonitor);
                for (int i = 0; i <= numberLimit; i = i + 2)
                {
                    Console.Write($"{i} ");
                    Monitor.Pulse(_lockMonitor);
                    bool isLast = false;

                    if (i == numberLimit)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(_lockMonitor);
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lockMonitor);
            }
        }
        static void PrintOddNumbers()
        {
            try
            {
                Monitor.Enter(_lockMonitor);
                for (int i = 1; i <= numberLimit; i = i + 2)
                {
                    Console.Write($"{i} ");
                    Monitor.Pulse(_lockMonitor);
                    bool isLast = false;

                    if (i == numberLimit - 1)
                    {
                        isLast = true;
                    }
                    if (!isLast)
                    {
                        Monitor.Wait(_lockMonitor);
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lockMonitor);
            }
        }
    }
}
