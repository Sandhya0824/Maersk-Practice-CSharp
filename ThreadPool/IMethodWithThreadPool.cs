using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPoolProperties
{
    public interface IMethodWithThreadPool
    {
        void WithThreadPool();
        void Test(object obj);
    }
}
