namespace ThreadPriorityPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMethod method = new Method();

            Thread thread1 = new Thread(method.Task)
            {
                Name="Thread1"
            };
            thread1.Priority = ThreadPriority.Lowest;

            Thread thread2 = new Thread(method.Task)
            {
                Name = "Thread2"
            };
            thread2.Priority = ThreadPriority.BelowNormal;

            Thread thread3 = new Thread(method.Task)
            {
                Name = "Thread3"
            };
            thread3.Priority = ThreadPriority.Normal;

            Thread thread4 = new Thread(method.Task)
            {
                Name = "Thread4"
            };
            thread4.Priority = ThreadPriority.AboveNormal;

            Thread thread5 = new Thread(method.Task)
            {
                Name = "Thread5"
            };
            thread5.Priority = ThreadPriority.Highest;

            Console.WriteLine("Thread1 Priority: {0}", thread1.Priority);
            Console.WriteLine("Thread2 Priority: {0}", thread2.Priority);
            Console.WriteLine("Thread3 Priority: {0}", thread3.Priority);
            Console.WriteLine("Thread4 Priority: {0}", thread4.Priority);
            Console.WriteLine("Thread5 Priority: {0}", thread5.Priority);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

        }
    }
}