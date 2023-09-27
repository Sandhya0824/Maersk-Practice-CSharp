using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPoolProperties
{
    public interface IMethodWithThread
    {
        void WithThread();

        void Test(object obj);
    }
}
