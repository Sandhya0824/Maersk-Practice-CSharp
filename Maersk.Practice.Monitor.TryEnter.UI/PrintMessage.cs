using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.MonitorTryEnter.UI
{
    public class PrintMessage : IPrintMessage
    {
        private static readonly object _lock = new object();
        public void DisplayMessage()
        {
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(1000);
            bool lockTaken = false;

            try
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Trying to enter Critical Section ");
                Monitor.TryEnter(_lock, timeSpan,ref lockTaken);
                if (lockTaken)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Entered to enter the Critical Section ");

                    Console.WriteLine("The current thread is: ", Thread.CurrentThread.Name);
                }
                else
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " Cannot enter to the Critical Section ");
                }

            }
            finally
            {
                if (lockTaken)
                {
                    Monitor.Exit(_lock);
                    Console.WriteLine(Thread.CurrentThread.Name + " Exit from the Critical Section ");
                }
            }
            
        }
    }
}
