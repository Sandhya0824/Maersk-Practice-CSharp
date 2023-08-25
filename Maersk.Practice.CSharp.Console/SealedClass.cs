using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    public class Printer
    {
        public virtual void show()
        {
            Console.WriteLine("Inside Printer1 : Show");
        } 

        public virtual void display()
        {
            Console.WriteLine("Inside Printer1 : Display");
        }
    }

    sealed class Printer2 : Printer                         //sealed class
    {
        public sealed override void show()                  //sealed method
        {
            Console.WriteLine("Inside Printer2 : Show");
        }

        public override void display()
        {
            Console.WriteLine("Inside Printer2 : Display");
        }
    }

    internal class SealedClass
    {
       public static void Main(string[] args)
        {
            Printer printer1 = new Printer();
            printer1.show();
            printer1.display();

            Printer printer2 = new Printer2();
            printer2.show();
            printer2.display();
        }
    }
}
