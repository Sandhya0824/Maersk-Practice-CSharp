using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceTesting
{
    public class Tasks : ITasks
    {
        public void EvenSum()
        {
            double evenSum = 0;
            for(double i = 0; i <= 7000000; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum += i;
                }
            }
        }

        public void OddSum()
        {
            double oddSum = 0;
            for (double i = 0; i <= 7000000; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i;
                }
            }
        }
    }
}
