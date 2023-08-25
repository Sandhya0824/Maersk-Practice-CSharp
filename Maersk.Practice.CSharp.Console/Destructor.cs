using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class Destructor
    {
        public Destructor()
        {
            Console.WriteLine("Constructor Invoked");
        }

        ~Destructor()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }

    class Test { 
        static void Main(string[]args)
        {
            Destructor destructor = new Destructor();
            Destructor destructor1 = new Destructor();
        }   
    }
}
