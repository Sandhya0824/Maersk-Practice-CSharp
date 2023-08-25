using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    class ClassA
    {
        protected int a, b;

        public ClassA()
        {
            Console.WriteLine("Inside Default Constructor");
        }

        public ClassA(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("Inside Parameterized Constructor");
            Console.WriteLine("Actual values : "+"\na = " + a + " b = " + b);
        }

        public virtual void swap()
        {
            Console.WriteLine("Inside Overridden Method");
            Console.WriteLine("Before Swap : " + "a = " + a + " b = " + b);

            int temp = a;
            a = b;
            b=temp;

            Console.WriteLine("After Swap : " + "a = " + a + " b = " + b);
        }
        
    }

    class ClassB : ClassA
    {
        public ClassB() : base(){ }

        public ClassB(int a, int b) : base(a, b) { }

        public override void swap()
        {
            base.swap();

            Console.WriteLine("Inside Overridding Method");

            Console.WriteLine("Before Swap : " + "a = " + a + " b = " + b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After Swap : " + "a = " + a + " b = " + b);
        }
    }
    internal class MethodOverriding
    {
        public static void Main(string[] args)
        {
            ClassB classB = new ClassB();

            ClassB classB1 = new ClassB(10,20);
            
            classB1.swap();
        }
    }
}
