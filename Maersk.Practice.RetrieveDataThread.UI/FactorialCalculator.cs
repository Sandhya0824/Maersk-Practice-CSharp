using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.RetrieveDataThread.UI
{
    public delegate void ResultCallBackDelegate(int result);

    public class FactorialCalculator : IFactorialCalculator
    {
        private int _number;
        private ResultCallBackDelegate _resultCallBackDelegate;

        public FactorialCalculator(int number, ResultCallBackDelegate resultCallBackDelegate)
        {
            _number = number;
            _resultCallBackDelegate = resultCallBackDelegate;
        }

        public void CalculateFactorial()
        {
            int result = 1;
            for(int i=2; i <= _number; i++)
            {
                result *= i;
            }

            if (_resultCallBackDelegate != null)
            {
                _resultCallBackDelegate(result);
            }
        }
    }
}
