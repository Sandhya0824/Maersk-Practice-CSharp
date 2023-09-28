namespace ThreadTermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITasks tasks = new Tasks();

            Thread thread = new Thread(tasks.Task)
            {
                Name="Thread1"
            };

            thread.Start();

            Thread.Sleep(1000);

            thread.Abort();

            thread.Join();

            Console.WriteLine("Main thread Aborted");
        }
    }
}