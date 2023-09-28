using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Multithreading
{
    internal class JoinAndIsAlive
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);
            thread1.Start();
            thread2.Start();
            thread3.Start();

            
            
           

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }

            thread1.Join();

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread1 Method1 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread1 Method1 Completed its work");
            }

            if (thread2.IsAlive)
            {
                Console.WriteLine("Thread2 Method2 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread2 Method2 Completed its work");
            }

            thread2.Join();

            if (thread2.IsAlive)
            {
                Console.WriteLine("Thread2 Method2 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread2 Method2 Completed its work");
            }

            thread3.Join();

        }
        static void Method1()
        {
            Console.WriteLine("Method1 - Thread1 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method1 - Thread 1 Ended");
        }
        static void Method2()
        {
            Console.WriteLine("Method2 - Thread2 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method2 - Thread2 Ended");
        }
        static void Method3()
        {
            Console.WriteLine("Method3 - Thread3 Started");
            Thread.Sleep(5000);
            Console.WriteLine("Method3 - Thread3 Ended");
        }
    }
}

