using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.MutexProperties.UI
{
    public class MutexDemoMessage : IMutexDemoMessage
    {
        private static Mutex mutex = new Mutex();
        public void MutexDemo()
        {
           Console.WriteLine(Thread.CurrentThread.Name+" wants to enter critical section");
            if(mutex.WaitOne(TimeSpan.FromSeconds(5)))
            {
                try
                {
                    Console.WriteLine("Success: " + Thread.CurrentThread.Name + " processing now");

                    Thread.Sleep(1000);

                    Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " completed processing");
                }
                finally
                {
                    mutex.ReleaseMutex();
                    Console.WriteLine(Thread.CurrentThread.Name + " has released mutex"); ;
                }
            }
            else
            {
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " will not acquire mutex");
            }
        }
    }
}
