using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Delegates.UI
{
    public class Calculator : ICalculator
    {
        public double Add(int x, int y)
        {
            return x + y;
        }

        public double Subtract(int x, int y)
        {
            return x - y;
        }

        public double Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
