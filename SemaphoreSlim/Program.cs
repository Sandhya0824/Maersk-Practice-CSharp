namespace SemaphoreSlimProperties
{
    internal class Program
    {
        private static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(0, 2);
        private static int padding;
        static void Main()
        {
            Console.WriteLine("{0} tasks can enter the semaphore",semaphoreSlim.CurrentCount);
            Task[] tasks = new Task[6];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() =>
                { 
                    Console.WriteLine("Begins and Waits: Task {0} begins and waits for the Semaphore", Task.CurrentId);

                int semaphoreCount;
                semaphoreSlim.Wait();

                try
                {
                    Interlocked.Add(ref padding, 100);
                    Console.WriteLine("Enters: Task {0} enters the Semaphore", Task.CurrentId);
                    Thread.Sleep(1000 + padding);
                }
                finally
                {
                    semaphoreCount = semaphoreSlim.Release();
                }

                Console.WriteLine("Release: Task {0} releases the Sempahore \n Previous Count: {1}", Task.CurrentId, semaphoreCount);
                
                });

        }

            Thread.Sleep(1000);

            Console.WriteLine("Main Thread Releases(2) ---> ");
            semaphoreSlim.Release(2);
            Console.WriteLine("Entry: {0} tasks can enter the Semaphore", semaphoreSlim.CurrentCount);

            Task.WaitAll(tasks);

            Console.WriteLine("Exit: Main Thread");
        }
    }
}