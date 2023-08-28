using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class Function
    {
        //Function using no parameter and return type
        public void Show() // No Parameter  
        {
            Console.WriteLine("This is non parameterized function");
            // No return statement  


        }
        //Function using parameter but no return type
        public void Show1(string message)
        {
            Console.WriteLine("Hello " + message);
        }
        //Function using parameter and return type
        public string Show2(string message1)
        {
            Console.WriteLine("Function using parameter and return type");
            Console.WriteLine("Hello " + message1);
            return message1;
        }
        //Call by value

        /*In C#, value-type parameters are that pass a copy of original value to the function rather than reference. 
         * It does not modify the original value. 
         * A change made in passed value does not alter the actual value. 
         * In the following example, we have pass value during function call.*/
        public void CallByValue(int val)
        {
            val *= val;

            Console.WriteLine("Value inside the CallByValue function: " + val);
        }
        //Call by Refrence
        /**/
        public void CallByRefrence(ref int val)
        {
            val *= val;

            Console.WriteLine("Value inside the CallByValue function: " + val);
        }
        static void Main(string[] args)
        {
            Function program = new Function(); // Creating Object  
            program.Show(); // Calling Function
            program.Show1("Aakriti Kumari");
            program.Show2("Aakriti");
            int val = 50;
            Console.WriteLine("Value before calling the CallByValue function: " + val);
            program.CallByValue(val);
            Console.WriteLine("Value after calling the CallByValue function: " + val);
            int val1 = 50;
            Console.WriteLine("Value before calling the CallByRefrence function: " + val1);
            program.CallByRefrence(ref val1);
            Console.WriteLine("Value after calling the CallByRefrence function: " + val1);



        }
    }
}
