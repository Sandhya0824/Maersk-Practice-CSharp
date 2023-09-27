namespace Maersk.Practice.SemaphoreProperties.UI
{
    internal class Program
    {
        public static Semaphore semaphore = null;
        static void Main(string[] args)
        {
            try
            {
                semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            }
            catch 
            {
                semaphore = new Semaphore(2, 2, "SemaphoreDemo");
            }

            Console.WriteLine("Trying to Acquire External Thread");
            semaphore.WaitOne();
            Console.WriteLine("External Thread Acquired");

            semaphore.Release();
        }
    }
}