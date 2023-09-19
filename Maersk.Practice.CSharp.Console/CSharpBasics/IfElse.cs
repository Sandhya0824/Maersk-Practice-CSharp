using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{

    internal class IfElse
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine((int)Colors.blue); 
            System.Console.WriteLine((int)Colors.green); 
            System.Console.WriteLine((int)Colors.red);

            System.Console.WriteLine("Enter your name: ");
            string s = System.Console.ReadLine();

            System.Console.WriteLine("Enter your marks:");
            int m = Convert.ToInt32(System.Console.ReadLine());

            string startsWith = s.Substring(0, 1);

            if (m >= 90)
            {
                System.Console.WriteLine("Eligible in Old Group {0}", startsWith.ToUpper());
            }
            else if (m >= 80 && m < 90)
            {
                System.Console.WriteLine("Eligible in Middle Group {0}", startsWith.ToUpper());
            }
            else if (m >= 70 && m < 80)
            {
                System.Console.WriteLine("Eligible in Young Group {0}", startsWith.ToUpper());
            }
            else
            {
                System.Console.WriteLine("Not eligble in any Group for now!!!");
            }

        }

    }

}
