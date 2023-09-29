using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class ThreadLifeCycleExample
    {
        static void Main(string[] args)
        {
            try
            {
                Thread thread1 = new Thread(Method1);
                Console.WriteLine($"Before Start, IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");
                
                thread1.Start();
                Console.WriteLine($"After Start(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");
                
                thread1.Suspend();
                Console.WriteLine($"After Suspend(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");
                
                thread1.Resume();
                Console.WriteLine($"After Resume(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");
                
                thread1.Abort();
                Console.WriteLine($"After Abort(), IsAlive: {thread1.IsAlive}, ThreadState: {thread1.ThreadState}");
                
                thread1.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
            }

            Console.ReadKey();
        }
        public static void Method1()
        {
            for (int x = 0; x < 3; x++)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("SomeMethod Completed...");
        }
    }
}

