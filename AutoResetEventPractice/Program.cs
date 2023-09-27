namespace AutoResetEventPractice
{
    public class Program
    {
        public static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            IMethod method = new Method();
            Thread thread = new Thread(method.Print);
            thread.Start();

            Thread.Sleep(1000);
            Console.WriteLine("Releasing the waitone one set by one");
            autoResetEvent.Set();

            Console.WriteLine("Releasing the waitone two set by two");
            autoResetEvent.Set();
        }
    }
}