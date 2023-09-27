using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPoolProperties
{
    public class MethodWithThreadPool : IMethodWithThreadPool
    {
        public void Test(object obj)
        {
            
        }

        public void WithThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }
    }
}
