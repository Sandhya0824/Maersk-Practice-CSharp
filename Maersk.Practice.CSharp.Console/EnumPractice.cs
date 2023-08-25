using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    public enum State: byte
    {
        On=0, Off=1
    }
    public enum Colors                  //The main objective of enum is to define our own data types(Enumerated Data Types). 
    {                                   //Enumeration is declared using enum keyword directly inside a namespace, class, or structure
        blue, green = 9, red
    }
    internal class EnumPractice
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((byte)Colors.red);

            foreach(string s in Enum.GetNames(typeof(Colors)))  //An enum type is a special data type that enables for a variable to be a set of predefined constants
            {
                Console.WriteLine(s);
            }

        }
    }
}
