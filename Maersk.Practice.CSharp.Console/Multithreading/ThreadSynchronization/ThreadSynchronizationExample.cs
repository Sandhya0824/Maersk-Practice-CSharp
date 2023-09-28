using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.Console.Multithreading
{
    class Printer
    {
        public void PrintTable()
        {
            lock (this)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    System.Console.WriteLine(i);
                }
            }
        }
    }
    public class ThreadSynchronizationExample
    {
        public static void Main(string[] args)
        {
            Printer p = new Printer();
            Thread thread1 = new Thread(new ThreadStart(p.PrintTable));
            Thread thread2 = new Thread(new ThreadStart(p.PrintTable));
            thread1.Start();
            thread2.Start();
        }
    }
}
