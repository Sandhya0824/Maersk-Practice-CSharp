using System.Diagnostics;

namespace ThreadPoolProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMethodWithThread methodWithThread = new MethodWithThread();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            methodWithThread.WithThread();
            stopwatch.Stop();
            Console.WriteLine("With Thread Time Taken: {0}", stopwatch.ElapsedMilliseconds);

            IMethodWithThreadPool methodWithThreadPool = new MethodWithThreadPool();
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            methodWithThread.WithThread();
            stopwatch1.Stop();
            Console.WriteLine("With Thread Time Taken: {0}", stopwatch1.ElapsedMilliseconds);

        }
    }
}