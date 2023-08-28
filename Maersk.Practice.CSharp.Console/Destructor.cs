using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class Complex
    {
        int real, img;
        public Complex()
        {
            real = 0;
            img = 0;
        }
        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }
        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }
    }
    public class Employee1
    {
        public Employee1()
        {
            Console.WriteLine("Constructor Invoked");
        }
        ~Employee1()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }

    public class Destructor
    {
       public static void Main(string[] args)
        {
            Complex C = new Complex();
            C.SetValue(2, 3);
            C.DisplayValue();
            Employee1 e1 = new Employee1();
            Employee1 e2 = new Employee1();
        } 
    }
}
