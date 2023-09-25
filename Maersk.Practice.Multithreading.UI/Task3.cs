using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Multithreading.UI
{
    public class Task3 : ITask3
    {
        public void Method3()
        {
            Console.WriteLine("Method3 starting: " + Thread.CurrentThread.Name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method3: " + i);
            }
            Console.WriteLine("Method3 ended using: " + Thread.CurrentThread.Name);
        }
    }
}
