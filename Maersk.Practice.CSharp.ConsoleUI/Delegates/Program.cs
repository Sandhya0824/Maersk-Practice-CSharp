using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double num1 = 10.0;
            double num2 = 5.0;

            double result1 = calculator.PerformOperation(num1, num2, calculator.Add);
            Console.WriteLine($"Addition result: {result1}");

            double result2 = calculator.PerformOperation(num1, num2, calculator.Subtract);
            Console.WriteLine($"Subtraction result: {result2}");

            double result3 = calculator.PerformOperation(num1, num2, calculator.Multiply);
            Console.WriteLine($"Multiplication result: {result3}");

            double result4 = calculator.PerformOperation(num1, num2, calculator.Divide);
            Console.WriteLine($"Division result: {result4}");
        }
    }
}
