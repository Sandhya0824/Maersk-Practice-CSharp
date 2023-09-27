using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPriorityPractice
{
    public class Method : IMethod
    {
        public void Task()
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} is Printing {1}", Thread.CurrentThread.Name, i);
            }
        }
    }
}
