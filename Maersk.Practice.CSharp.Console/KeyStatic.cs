using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    static class Tutorial //Static Class
    {
        public static string Topic = "Static keyword";//Staic variable
        public static void display() //static method
        {
            Console.WriteLine("Today I studied about "+Topic+" topic.");
        }
        static Tutorial() //satic constructor
        {
            Console.WriteLine("Static constructor is called");
        }
    }
    

    public class KeyStatic
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Topic name is : "+Tutorial.Topic);
            Tutorial.display();//Calling static method 
        }
    }
}
