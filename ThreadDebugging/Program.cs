namespace ThreadDebugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(SomeMethod)
            {
                Name = "Thread One"
            };

            Thread thread2 = new Thread(SomeMethod)
            {
                Name = "Thread Two"
            };

            thread1.Start();
            thread2.Start();
        }

        public static void SomeMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                i++;
                Thread.Sleep(5000);
            }
        }
    }
}