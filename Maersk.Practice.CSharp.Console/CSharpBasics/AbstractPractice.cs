using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    abstract class Program1
    {
        protected int i;

        public void display()
        {
            System.Console.WriteLine("Inside Abstract Class");
        }
        public abstract int Subtract(int x, int y);

        public abstract void Swap(int x, int y);

        public abstract int getNumber { get; set; }

    }

    class Program2 : Program1
    {
        public override int Subtract(int x, int y)
        {
            return x - y;
        }

        public override void Swap(int x, int y)
        {
            System.Console.WriteLine("Before Swap x = " + x + " y = " + y);
            int temp = x; x = y; y = temp;
            System.Console.WriteLine("After Swap x = " + x + " y = " + y);
            return;
        }

        public override int getNumber { get { return i; } set { i = value; } }
    }

    internal class AbstractPractice
    {
        public static void Main(string[] args)
        {
            Program2 program2 = new Program2();

            program2.display();

            System.Console.WriteLine(program2.Subtract(100, 2));

            program2.Swap(60, 90);

            program2.getNumber = 101;
            System.Console.WriteLine("Number : " + program2.getNumber);
        }
    }
}
