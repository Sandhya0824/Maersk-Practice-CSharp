using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.RetrievingDataFromThreadFunction
{
    internal class HelperClass
    {
        public delegate void CallbackDelegate(int Results);

        private int _number;
        private CallbackDelegate _callbackDelegate;
        
        public HelperClass(int number, CallbackDelegate callbackDelagate)
        {
            _number = number;
            _callbackDelegate = callbackDelagate;
        }
        
        public void CalculateSum()
        {
            int result = 0;
            for (int i = 1; i <= _number; i++)
            {
                result = result + i;
            }
            
            if (_callbackDelegate != null)
            {
                _callbackDelegate(result);
            }
        }
    }
}
