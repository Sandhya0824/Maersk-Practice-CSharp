using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class ThreadPriorityExample
    {
        public static void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Worker thread: {Thread.CurrentThread.Name}, Iteration: {i}");
            }
        }

        static void Main(string[] args)
        {
            Thread highPriorityThread = new Thread(Method1);
            Thread normalPriorityThread = new Thread(Method1);
            Thread lowPriorityThread = new Thread(Method1);

            highPriorityThread.Name = "High Priority Thread";
            normalPriorityThread.Name = "Normal Priority Thread";
            lowPriorityThread.Name = "Low Priority Thread";

            highPriorityThread.Priority = ThreadPriority.Highest;
            normalPriorityThread.Priority = ThreadPriority.Normal;
            lowPriorityThread.Priority = ThreadPriority.Lowest;

            highPriorityThread.Start();
            normalPriorityThread.Start();
            lowPriorityThread.Start();

            //highPriorityThread.Join();
            //normalPriorityThread.Join();
            //lowPriorityThread.Join();

            Console.WriteLine("All threads have finished.");
        }
    }
}
