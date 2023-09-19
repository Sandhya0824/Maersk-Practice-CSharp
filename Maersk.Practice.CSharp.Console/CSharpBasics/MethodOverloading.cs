using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    internal class MethodOverloading
    {
        public int Add(int a, int b)            //Overloaded Method
        {
            System.Console.WriteLine("Inside Overloaded Method");
            return a + b;
        }

        public int Add(int a, int b, int c)     //No.of parameters diff.
        {
            System.Console.WriteLine("Inside No.of parameters diff.");
            return a + b + c;
        }

        public int Add(string s, int a, int b, int c)     // Type Of Parameters difff.
        {
            System.Console.WriteLine("Inside Type(int) of parameters diff.");
            return a + b + c;
        }

        public double Add(string s, double a, double b, int c)     // Type Of Parameters difff.
        {
            System.Console.WriteLine("Inside Type(double) of parameters diff.");
            return a + b + c;
        }

        public int Add(int a, int b, int c, string s)      //Order of parameters diff.
        {
            System.Console.WriteLine("Inside Order of parameters diff.");
            return a + b + c;
        }
        public static void Main(string[] args)
        {
            MethodOverloading methodOverloading = new MethodOverloading();
            System.Console.WriteLine(methodOverloading.Add(1, 2));
            System.Console.WriteLine(methodOverloading.Add(1, 2, 3));
            System.Console.WriteLine(methodOverloading.Add("a", 1, 2, 3));
            System.Console.WriteLine(methodOverloading.Add("a", 1.0, 2.0, 3));
            System.Console.WriteLine(methodOverloading.Add(1, 2, 3, "a"));
        }
    }
}
