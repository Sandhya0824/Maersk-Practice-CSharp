using System.Diagnostics;

namespace PerformanceTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITasks tasks = new Tasks();

            Stopwatch stopwatch = Stopwatch.StartNew();
            tasks.EvenSum();
            tasks.OddSum();
            stopwatch.Stop();
            Console.WriteLine("Total time taken for single threaded: {0}", stopwatch.ElapsedMilliseconds);

            stopwatch.Restart();
            Thread thread1 = new Thread(tasks.EvenSum);
            Thread thread2 = new Thread(tasks.OddSum);
            thread1.Start();
            thread2.Start();
            stopwatch.Stop();
            Console.WriteLine("Total time taken for multi-threaded: {0}", stopwatch.ElapsedMilliseconds);

        }
    }
}