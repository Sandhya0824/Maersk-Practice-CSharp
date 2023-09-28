using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadTermination
{
    public class Tasks : ITasks
    {
        public void Task()
        {
            try
            {
                Console.WriteLine("{0} has started it's execution", Thread.CurrentThread.Name);

                for(int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("{0} is Printing {1}", Thread.CurrentThread.Name, i);
                    Thread.Sleep(2);
                }

                Console.WriteLine("{0} has finished it's execution", Thread.CurrentThread.Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thread Aborted: {0}",ex.ToString());
            }
        }
    }
}
