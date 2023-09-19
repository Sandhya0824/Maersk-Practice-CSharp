using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    class ClassAnimal
    {
        public virtual void sound()
        {
            System.Console.WriteLine("Animal makes sound");
        }
    }

    class Bird : ClassAnimal
    {
        public override void sound()
        {
            System.Console.WriteLine("Bird Chirps");
        }
    }

    class Dog : ClassAnimal
    {
        public override void sound()
        {
            System.Console.WriteLine("Dog Barks");
        }
    }
    internal class Polymorphism
    {
        public static void Main(string[] args)
        {
            ClassAnimal classAnimal = new ClassAnimal();
            classAnimal.sound();

            ClassAnimal classAnimal1 = new Bird();
            classAnimal1.sound();

            ClassAnimal classAnimal2 = new Dog();
            classAnimal2.sound();

        }
    }
}
