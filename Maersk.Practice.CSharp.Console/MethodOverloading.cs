using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    internal class MethodOverloading
    {
        public int Add(int a, int b)            //Overloaded Method
        {
            Console.WriteLine("Inside Overloaded Method");
            return a + b;
        }

        public int Add(int a, int b, int c)     //No.of parameters diff.
        {
            Console.WriteLine("Inside No.of parameters diff.");
            return a + b + c;
        }

        public int Add(String s,int a,int b,int c)     // Type Of Parameters difff.
        {
            Console.WriteLine("Inside Type(int) of parameters diff.");
            return  a + b + c;
        }

        public double Add(String s, double a, double b, int c)     // Type Of Parameters difff.
        {
            Console.WriteLine("Inside Type(double) of parameters diff.");
            return a + b + c;
        }

        public int Add(int a,int b,int c,String s)      //Order of parameters diff.
        {
            Console.WriteLine("Inside Order of parameters diff.");
            return a + b + c;
        }
        public static void Main(string[] args)
        { 
            MethodOverloading methodOverloading = new MethodOverloading();
            Console.WriteLine(methodOverloading.Add(1, 2));
            Console.WriteLine(methodOverloading.Add(1,2,3));
            Console.WriteLine(methodOverloading.Add("a",1,2,3));
            Console.WriteLine(methodOverloading.Add("a", 1.0, 2.0, 3));
            Console.WriteLine(methodOverloading.Add(1,2,3,"a"));
        }
    }
}
