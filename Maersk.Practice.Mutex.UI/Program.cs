namespace Maersk.Practice.MutexProperties.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMutexDemoMessage mutexDemoMessage = new MutexDemoMessage();
            for(int i = 0; i < 3; i++) 
            {
                Thread thread = new Thread(mutexDemoMessage.MutexDemo)
                {
                    Name="Thread"+i
                };
                thread.Start();
            }
        }
    }
}