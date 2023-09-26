namespace Maersk.Practice.Join.IsAlive.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Thread thread1 = new Thread(Method1);
            Thread thread2 = new Thread(Method2);
            Thread thread3 = new Thread(Method3);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            if(thread1.Join(TimeSpan.FromSeconds(5)))
            {
                Console.WriteLine("Thread1 execution completed in 5 seconds");
            }
            else 
            {
                Console.WriteLine("Thread1 execution not completed in 5 seconds");
            }

            if (thread3.IsAlive)
            {
                Console.WriteLine("Thread3 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread3 Execution Completed");
            }

            thread3.Join();

            if (thread3.IsAlive)
            {
                Console.WriteLine("Thread3 is still Executing");
            }
            else
            {
                Console.WriteLine("Thread3 Execution Completed");
            }

            if (thread2.Join(3000))
            {
                Console.WriteLine("Thread2 execution completed in 3 seconds");
            }
            else
            {
                Console.WriteLine("Thread2 execution not completed in 3 seconds");
            }

            

            Console.WriteLine("Main Thread Ended");

        }

        static void Method1()
        {
            Console.WriteLine("Method1: Thread1 Started");
            Thread.Sleep(9000);
            Console.WriteLine("Method1: Thread1 Ended");
        }

        static void Method2()
        {
            Console.WriteLine("Method2: Thread2 Started");
            Thread.Sleep(9000);
            Console.WriteLine("Method2: Thread2 Ended");
        }

        static void Method3()
        {
            Console.WriteLine("Method3: Thread3 Started");
            Thread.Sleep(9000);
            Console.WriteLine("Method3: Thread3 Ended");
        }
    }
}