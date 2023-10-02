using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.PassingDataToThreadInATypeSafeManner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            HelperClass obj = new HelperClass(num);

            Thread T1 = new Thread(new ThreadStart(obj.DisplayNumbers));
            T1.Start();
        }
    }
}
