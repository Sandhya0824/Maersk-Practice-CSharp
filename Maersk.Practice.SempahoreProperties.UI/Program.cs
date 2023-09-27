namespace Maersk.Practice.SempahoreProperties.UI
{
    internal class Program
    {
        public static Semaphore semaphore = new Semaphore(2, 4); //initial count  and Max Count for CS
        static void Main(string[] args)
        {
            ITasks tasks = new Tasks();

            for(int i = 0; i < 15; i++)
            {
                Thread threads = new Thread(tasks.DoTask)
                {
                    Name="Thread"+i
                };
                threads.Start();
            }
            
        }
    }
}