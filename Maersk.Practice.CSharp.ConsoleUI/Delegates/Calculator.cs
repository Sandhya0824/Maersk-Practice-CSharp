using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Delegates
{
    public class Calculator
    {
        public delegate double BinaryOperation(double x, double y);

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }

        public double PerformOperation(double x, double y, BinaryOperation operation)
        {
            return operation(x, y);
        }

    }
}
