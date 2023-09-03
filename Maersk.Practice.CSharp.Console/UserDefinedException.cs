using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message):base(message) 
        {

        }
    }
    public class DivByZero : Exception
    {
        public DivByZero()
        {
            Console.Write("Exception has occurred : ");
        }
    }
    class Program
    {
        public double DivisionOperation(double numerator,
                                     double denominator)
        {
            if (denominator == 0)
                throw new DivByZero();

            return numerator / denominator;
        }
    }
    public class UserDefinedException
    {
        public static void validate(int age)
        {
            if (age<18)
            {
                throw new InvalidAgeException("Sorry age must be greater than 18");  
            }
        }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            double num = 9, den = 0, quotient;
            try
            {
                validate(12);
                quotient = obj.DivisionOperation(num, den);
                Console.WriteLine("Quotient = {0}", quotient);
            }
            catch(InvalidAgeException e) 
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the code");
        }
    }
}
