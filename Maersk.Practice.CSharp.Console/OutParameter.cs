using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    internal class OutParameter
    {
        public int outParameter(out int a)
        {
            a = 10;
            return a;
        }


        public static void Main(String[] args)
        {
            int t;      //not initialized
            OutParameter obj3 = new OutParameter();
            obj3.outParameter(out t);
            Console.WriteLine("Value After Out Parameter: {0} ", t);
        }
    }
}
