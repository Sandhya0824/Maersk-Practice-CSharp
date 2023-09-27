using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPoolProperties
{
    public class MethodWithThread : IMethodWithThread
    {
        public void Test(object obj)
        {
        }

        public void WithThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(Test);
                thread.Start();
            }
        }
    }
}
