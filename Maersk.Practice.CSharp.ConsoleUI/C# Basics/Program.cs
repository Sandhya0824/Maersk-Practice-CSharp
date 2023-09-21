using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PracticeCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Minimum Range of Decimal datatype is : {0} ", Decimal.MinValue);
            Console.WriteLine("The Minimum Range of Float datatype is : {0} ", Single.MinValue);
            Console.WriteLine("The Minimum Range of Double datatype is : {0} ", Double.MinValue);
       
            Console.WriteLine("The Maximum Range of the Decimal datatype is : {0} ", Decimal.MaxValue);
            Console.WriteLine("The Maximum Range of the Float datatype is : {0} ", Single.MaxValue);
            Console.WriteLine("The Maximum Range of the Decimal datatype is : {0} ", Double.MaxValue);

            //----------------------------------------------------------

            int number, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();

            //--------------------------------------------------------------

            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt16(Console.ReadLine());
            double SqrtNum = Math.Sqrt(num);
            Console.WriteLine("Square root of {0} is: {1}", num, SqrtNum);
            Console.ReadLine();
        }
    }
}