using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.RetrieveDataThread.UI
{
    public class FactorialResult : IFactorialResult
    {
        public void DisplayResult(int result)
        {
            Console.WriteLine(result);
        }
    }
}
