using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.Console.Multithreading
{
    public class NumberHelper
    {
        int _Number;

        public NumberHelper(int Number)
        {
            _Number = Number;
        }

        public void DisplayNumbers()
        {
            for (int i = 1; i <= _Number; i++)
            {
                System.Console.WriteLine("value : " + i);
            }
        }
    }
    public class PassDataToThreadFunctionInTypeSafeManner
    {
        public static void Main(string[] args)
        {
            int Max = 10;
            NumberHelper obj = new NumberHelper(Max);

            Thread T1 = new Thread(new ThreadStart(obj.DisplayNumbers));

            T1.Start();
            System.Console.Read();
        }
    }
}
