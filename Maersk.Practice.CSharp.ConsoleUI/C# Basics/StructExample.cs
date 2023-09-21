using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public struct Person
    {
        public string Name;
        public int Age;
        public int Weight;
    }

    public class StructExample
    { 
        static void Main(string[] args)
        {

            Person P1; //no need of new keyword

            P1.Name = "Harsh";
            P1.Age = 21;
            P1.Weight = 80;

            Person P2;

            P2 = P1; //new structure is created with "=" operator

            Console.WriteLine("Values Stored in P1");
            Console.WriteLine("Name: " + P1.Name);
            Console.WriteLine("Age: " + P1.Age);
            Console.WriteLine("Weight: " + P1.Weight);
            Console.WriteLine();

            Console.WriteLine("Values Stored in P2");
            Console.WriteLine("Name: " + P2.Name);
            Console.WriteLine("Age: " + P2.Age);
            Console.WriteLine("Weight: " + P2.Weight);

        }
    }
}
