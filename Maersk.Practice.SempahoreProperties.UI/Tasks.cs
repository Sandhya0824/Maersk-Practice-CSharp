using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.SempahoreProperties.UI
{
    public class Tasks : ITasks
    {

        public void DoTask()
        {
            Console.WriteLine("Waiting: {0} wants to enter the Critical Section", Thread.CurrentThread.Name);

            try
            {
                Program.semaphore.WaitOne();
                Console.WriteLine("Success: {0} has aquired the Critical Section", Thread.CurrentThread.Name);
                Thread.Sleep(1000);
                Console.WriteLine("Exit: {0}", Thread.CurrentThread.Name);
            }
            catch
            {

            }
            finally
            {
                Program.semaphore.Release();
            }
        }
    }
}
