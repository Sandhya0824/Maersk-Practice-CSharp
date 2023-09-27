namespace ManualResetEventPractice
{
    internal class Program
    {
        public static ManualResetEvent autoResetEvent = new ManualResetEvent(true); //not set if true immediately proceeds and prints all the statements for waitone then no need of set if true
        static void Main(string[] args)
        {
            IMethod method = new Method();
            Thread thread = new Thread(method.Print);
            thread.Start();

            Thread.Sleep(1000);
            Console.WriteLine("Releasing the waitone one set by one");
            autoResetEvent.Set();       //automatically sets all wait states

            
        }
    }
}