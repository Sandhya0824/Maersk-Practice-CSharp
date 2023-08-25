using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class BaseKeyword
    {
        public class BaseClass
        {
            int num;

            public BaseClass()
            {
                Console.WriteLine("in BaseClass()");
            }

            public BaseClass(int i)
            {
                num = i;
                Console.WriteLine("in BaseClass(int i)");
            }
        }

        public class DerivedClass : BaseClass
        {
            // This constructor will call BaseClass.BaseClass() (non-parameterized constructor of the base class)
            public DerivedClass() : base()
            {
                Console.WriteLine("in DerivedClass()");
            }

            // This constructor will call BaseClass.BaseClass(int i) (parameterized constructor of the base class)
            public DerivedClass(int i) : base(i)
            {
                Console.WriteLine("in DerivedClass(int i)");
            }

            static void Main()
            {
                DerivedClass d = new DerivedClass();
                DerivedClass d1 = new DerivedClass(1);
            }
        }
    }
}
