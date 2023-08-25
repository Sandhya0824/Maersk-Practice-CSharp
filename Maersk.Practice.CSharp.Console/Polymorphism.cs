using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    class ClassAnimal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    
    class Bird : ClassAnimal
    {
        public override void sound()
        {
            Console.WriteLine("Bird Chirps");
        }
    }

    class Dog : ClassAnimal
    {
        public override void sound()
        {
            Console.WriteLine("Dog Barks");
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
