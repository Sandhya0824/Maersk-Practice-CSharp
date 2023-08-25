using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
   
    internal class IfElse
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((int)Colors.blue); Console.WriteLine((int)Colors.green); Console.WriteLine((int)Colors.red);

            Console.WriteLine("Enter your name: ");
            String s = Console.ReadLine();

            Console.WriteLine("Enter your marks:");
            int m = Convert.ToInt32(Console.ReadLine());

            String startsWith = s.Substring(0, 1);

            if (m >= 90)
            {
                Console.WriteLine("Eligible in Old Group {0}", startsWith.ToUpper());
            }
            else if (m >= 80 && m < 90)
            {
                Console.WriteLine("Eligible in Middle Group {0}", startsWith.ToUpper());
            }
            else if (m >= 70 && m < 80)
            {
                Console.WriteLine("Eligible in Young Group {0}", startsWith.ToUpper());
            }
            else
            {
                Console.WriteLine("Not eligble in any Group for now!!!");
            }

        }

    }
  
}
