using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.PassingDataToThreadInATypeSafeManner
{
    internal class HelperClass
    {
        private int _number;

        public HelperClass(int Number)
        {
            _number = Number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
