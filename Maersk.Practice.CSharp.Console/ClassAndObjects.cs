using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class ClassAndObjects
    {
        String name;
        int age;
        String colour;

        static void Main(string[] args)
        {
            ClassAndObjects cat = new ClassAndObjects();
            cat.name = "Kitty";
            cat.age = 2;
            cat.colour = "white";

            Console.WriteLine("Hi my name is {0}, I am {1} years old and I am {2} in colour.", cat.name, cat.age, cat.colour);
        }
    }
}
