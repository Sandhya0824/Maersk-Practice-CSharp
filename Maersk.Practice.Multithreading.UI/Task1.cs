using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Multithreading.UI
{
    public class Task1 : ITask1
    {
        public void Method1()
        {
            Console.WriteLine("Method1 starting: " + Thread.CurrentThread.Name);
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Method1: " + i);
            }
            Console.WriteLine("Method1 ended using: " + Thread.CurrentThread.Name);
        }
    }
}
