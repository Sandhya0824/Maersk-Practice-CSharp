using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class EnumExample
    {
        public enum Days {Sun, Mon, Tue, Wed, Thurs, Fri, Sat};

        static void Main(string[] args)
        {
            foreach(string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }

            foreach(Days d in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(d);
            }

        }
    }
}
