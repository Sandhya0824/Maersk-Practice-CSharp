using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.ThreadClass.UI
{
    public class ParameterizedMethodTypeSafe : IParameterizedMethodTypeSafe
    {
        private string _message;
        private string _name;
        public ParameterizedMethodTypeSafe(string name,string message)
        {
            _message = message;
            _name = name;
        }

        public void DisplayMessage()      //type safe
        {
            Console.WriteLine("Hello {0} {1}", _name, _message);
        }
    }
}
