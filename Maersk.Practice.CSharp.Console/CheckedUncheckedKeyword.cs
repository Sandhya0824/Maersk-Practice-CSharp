using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class CheckedUncheckedKeyword
    {
        public static void Main(string[] args)
        {
            int max=int.MaxValue;
            Console.WriteLine("Max value of integer: "+max);
            int a = max; 
            int b=max;
            int c = a + b;
            Console.WriteLine("Max value without checked and unchecked keyword: "+c);

            int e = unchecked(a + c);
            Console.WriteLine("Max value with unchecked keyword: "+e);

            try
            {
                int d = checked(a + b);
                Console.WriteLine("Max value with checked keyword: " + d);
            }
            catch(Exception f)
            {
                Console.WriteLine(f);
            }
            

            Console.ReadLine();
        }
    }
}
