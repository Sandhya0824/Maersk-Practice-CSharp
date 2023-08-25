using C_SharpLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using third;

//public -- anywhere
//protected -- containing subclasses but values can't be modified
//internal -- anywhere inside the same assembly(atomic unit of .NET) 
//protected internal -- same assembly and derived class
//private -- same class
//private protected -- same class and derived classes
namespace C_SharpLearning
{
    public class CheckAccess
    {
        public static int i;
        protected static int j;
        internal static int k;
        protected internal static int l;
        private static int m;
        private protected static int n;
    }
    public class AccessModifiers : CheckAccess
    {
        public static void Main(string[] args)
        {
            CheckAccess.i = 0;
            CheckAccess.j = 0;
            CheckAccess.k = 0;
            CheckAccess.l = 0;
            //   CheckAccess.m=0;    error
            CheckAccess.n = 0;
        }

    }
}
namespace first
{
    class Geeks_1                                       //not derived base class
    {
        static int g;
        public static void display()
        {
            System.Console.WriteLine("Hello Geeks!");

        }
        public static void Main(string[] args)
        {
            CheckAccess.i = 0;
            //   CheckAccess.j = 0; error
            CheckAccess.k = 0;
            CheckAccess.l = 0;                          
            //   CheckAccess.m=0;    error
            //   CheckAccess.n = 0;  error
        }

    }
}

namespace second
{                                 
    class Geeks_2 : CheckAccess                             // derived base class
    {
        static int g;
        public static void display()
        {
            System.Console.WriteLine("Hello Geeks!");

        }
        public static void Main(string[] args)
        {
            CheckAccess.i = 0;
            CheckAccess.j = 0; 
            CheckAccess.k = 0;
            CheckAccess.l = 0;
            //   CheckAccess.m=0;    error
            CheckAccess.n = 0;  
        }

    }
}

namespace third
{
    internal class Geeks_3
    {
        public void display() { }
    }

    class Geeks_5 
    {
        public static void main(string[] args)
        {
            Geeks_3 geeks_3 = new Geeks_3();
            geeks_3.display();
        }
    }
}

namespace fourth
{
    class Geeks_4
    {
        public static void main(string[] args)
        {
            Geeks_3 geeks_3 = new Geeks_3();        
            geeks_3.display();
        }
    }
}

