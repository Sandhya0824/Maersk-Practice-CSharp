namespace ForegroundBackgroundThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IThreadCheck foregroundCheck = new ThreadCheck(10);
            Thread foregroundThread = new Thread(new ThreadStart(foregroundCheck.Task));

            IThreadCheck backgroundCheck = new ThreadCheck(10);
            Thread backgorundThread = new Thread(new ThreadStart(backgroundCheck.Task))
            {
                IsBackground = true
            };

            foregroundThread.Start();
            backgorundThread.Start();
        }
    }
}