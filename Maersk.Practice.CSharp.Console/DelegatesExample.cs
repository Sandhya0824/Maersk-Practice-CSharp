using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.Console
{
    public class DelegatesExample
    {
        public delegate void addNumber(int a, int b);
        public delegate void substractNumber(int a, int b);
        public void Sum(int a, int b)
        {
            System.Console.WriteLine(a+b);
        }
        public static void Substract(int a, int b) //If methods are static then there is no need to create the object of the class.
        {
            System.Console.WriteLine(a-b);
        }

        public static void Main(string[] args)
        {
            DelegatesExample delegatesExample = new DelegatesExample();
            
            addNumber addNumbers = new addNumber(delegatesExample.Sum);
            substractNumber substractNumbers = new substractNumber(Substract);

            addNumbers(100, 40);
            substractNumbers(100, 40);
            System.Console.WriteLine();


            //Multicasting
            System.Console.WriteLine("After multicasting");
            addNumbers += Substract;
            addNumbers.Invoke(999,100);

        }
    }
}
