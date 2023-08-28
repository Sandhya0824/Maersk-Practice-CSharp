using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class String
    {

        //String s2 = "welcome";//creating string using String class  
        public static void Main(string[] args)
        {
            string s1 = "hello";//creating string using string keyword  
            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s2 = new string(ch);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }

}
