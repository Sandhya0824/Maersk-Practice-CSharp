using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Maersk.Practice.SempahoreProperties.UI
{
    internal class SemaphoreControl
    {
        public static Semaphore semaphore = null;
        public static void SemaphoreOpen()
        {
            try
            {
                semaphore = Semaphore.OpenExisting("SemaphoreDemo");
            }
            catch
            {
                semaphore = new Semaphore(2, 2, "SemaphoreDemo");
            }

            Console.WriteLine("Trying to Acquire External Thread");
            semaphore.WaitOne();
            Console.WriteLine("External Thread Acquired");

            semaphore.Release();
        }
    }
}
