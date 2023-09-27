using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadLifeCycle
{
    public class Method : IMethod
    {
        public void Task()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Method Completed");
        }
    }
}
