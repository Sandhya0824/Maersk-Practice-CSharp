using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class ThreadClassExample
    {
        static void Main(string[] args)
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Main Thread";
            Console.WriteLine("Name given to the thread :" + thread.Name);
            Console.WriteLine("Name of the thread that is currently executing :" + Thread.CurrentThread.Name);
            Console.WriteLine(thread.IsAlive);
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine(thread.ManagedThreadId);
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(thread.IsBackground);
            //Console.WriteLine(Thread.CurrentThread.IsBackground);
            Console.WriteLine(thread.Priority);
        }
    }
}
