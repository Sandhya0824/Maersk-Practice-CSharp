namespace Maersk.Practice.Multithreading.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            ITask1 task1 = new Task1();
            Thread thread1 = new Thread(task1.Method1)
            {
                Name = "Thread1"
            };

            ITask2 task2 = new Task2();
            Thread thread2 = new Thread(task2.Method2)
            {
                Name = "Thread2"
            };

            ITask3 task3 = new Task3();
            Thread thread3 = new Thread(task3.Method3)
            {
                Name = "Thread3"
            };

            thread1.Start();
            thread2.Start();
            thread3.Start();

            Console.WriteLine("Main Thread Ended");

        }
    }
}