using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Multithreading.UI
{
    public class Task2 : ITask2
    {
        public void Method2()
        {
            Console.WriteLine("Method2 starting: " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method2: " + i);
                if (i == 2)
                {
                    Console.WriteLine("Operations started");
                    Thread.Sleep(9000);
                    Console.WriteLine("Operations stopped");
                }
            }
            Console.WriteLine("Method2 ended using: " + Thread.CurrentThread.Name);
        }
    }
}
