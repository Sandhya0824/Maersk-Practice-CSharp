using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class Value_Datatype
    {
        public static void  Main()
        {
            char a = 'A';
            int i = 89;
            short s = 56;
            //short s1 = 11111557;
            long l = 23232;
            uint ui = 98;
            ushort us = 76;
            ulong ul = 3452222;
            double d = 3.33;
            float f = 1.33f;
            decimal dec = 983.5m;
            sbyte b = 126;
            Console.WriteLine("sbyte: "+b);
            b++;
            b++;
            Console.WriteLine("sbyte: "+b);
            byte c = 255;
            Console.WriteLine("byte: "+c);
            c++;
            Console.WriteLine("byte: " + b);
            bool boolean=true;
            if(boolean==true)
            { 
                Console.WriteLine("HI there!");
            }
            else
            {
                Console.WriteLine("HI Ma'am!");
            }

            Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);
            Console.WriteLine("Unsinged short: " + us);
            Console.WriteLine("Unsinged long: " + ul);
        }
    }
}
