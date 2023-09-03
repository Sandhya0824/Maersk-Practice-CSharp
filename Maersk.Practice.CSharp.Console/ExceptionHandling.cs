using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            //Finally example if exception is handled
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("Rest of the code");

            //Finally example if exception is not handled
            try
            {
                int a = 10;
                int b = 0;
                int x = a / b;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Finally block is executed");
            }
            Console.WriteLine("Rest of the code");
        }
    }
}
