using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.ThreadClass.UI
{
    public class ParameterizedMethod : IParameterizedMethod
    {
        public void DisplayMessage(object message)      //no type safe
        {
            Console.WriteLine("Hello {0}",message);
        }
    }
}
