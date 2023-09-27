namespace Maersk.Practice.MonitorTryEnter.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];

            PrintMessage printMessage = new PrintMessage();
            for(int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(printMessage.DisplayMessage)
                {
                    Name="Thread"+i
                };
            }

            for(int i = 0;i < threads.Length;i++)
            {
                threads[i].Start();
            }
        }
    }
}