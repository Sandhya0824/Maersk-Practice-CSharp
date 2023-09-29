using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class ForegroundAndBackgroundThreads
    {
        static void Main()
        {
            int foregroundThreadCount = 3;
            int backgroundThreadCount = 5;

            Console.WriteLine("Creating foreground threads:");
            for (int i = 1; i <= foregroundThreadCount; i++)
            {
                Thread thread = new Thread(ForegroundThreadWork);
                thread.Name = $"Foreground Thread {i}";
                thread.Start();
            }

            Console.WriteLine("Creating background threads:");
            for (int i = 1; i <= backgroundThreadCount; i++)
            {
                Thread thread = new Thread(BackgroundThreadWork);
                thread.Name = $"Background Thread {i}";
                thread.IsBackground = true;
                thread.Start();
            }

            Console.WriteLine("Main thread is running.");
            Console.ReadLine();
        }

        static void ForegroundThreadWork()
        {
            string threadName = Thread.CurrentThread.Name;
            Console.WriteLine($"{threadName} is running.");
            Thread.Sleep(2000); 
            Console.WriteLine($"{threadName} has completed.");
        }

        static void BackgroundThreadWork()
        {
            string threadName = Thread.CurrentThread.Name;
            Console.WriteLine($"{threadName} is running.");
            Thread.Sleep(2000); 
            Console.WriteLine($"{threadName} has completed.");
        }
    }
}
