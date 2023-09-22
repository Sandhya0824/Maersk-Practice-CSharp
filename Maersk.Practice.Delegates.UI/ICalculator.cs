using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.Delegates.UI
{ 
    public interface ICalculator
    {
        double Add(int x, int y);
        double Subtract(int x, int y);
        double Multiply(int x, int y);
    }
}
