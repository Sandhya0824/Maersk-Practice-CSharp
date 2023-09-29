using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Maersk.Practice.CSharp.ConsoleUI.RetrievingDataFromThreadFunction.HelperClass;

namespace Maersk.Practice.CSharp.ConsoleUI.RetrievingDataFromThreadFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallbackDelegate callbackDelegate = new CallbackDelegate(CallBackMethod);
            int number = 24;
            
            HelperClass obj = new HelperClass(number, callbackDelegate);
            Thread T1 = new Thread(new ThreadStart(obj.CalculateSum));

            T1.Start();
        }
        public static void CallBackMethod(int Result)
        {
            Console.WriteLine("The Result is " + Result);
        }
    }
}
