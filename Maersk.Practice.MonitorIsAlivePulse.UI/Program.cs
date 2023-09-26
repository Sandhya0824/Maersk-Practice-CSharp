namespace Maersk.Practice.MonitorIsAlivePulse.UI
{
    public class Program
    {
        public static readonly object _lockObject = new object();

        public static readonly int numberLimit = 10;

        static void Main(string[] args)
        {
            IEvenPrinter evenPrinter = new EvenPrinter();
            IOddPrinter oddPrinter = new OddPrinter();

            Thread evenThread = new Thread(evenPrinter.DisplayEvenNumbers);
            Thread oddThread = new Thread(oddPrinter.DisplayOddNumbers);

            evenThread.Start();
            Thread.Sleep(150);
            oddThread.Start();

            evenThread.Join();
            oddThread.Join();

        }
    }
}