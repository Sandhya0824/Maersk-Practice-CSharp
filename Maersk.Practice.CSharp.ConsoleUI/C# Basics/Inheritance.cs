using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    public class Inheritance
    {
        public void PerformFunction()
        {
            Console.WriteLine("Performing a function..");
        }

        class Vehicle : Inheritance  //single-level
        {
            public int id;
            public string name;
            public string type;

            public void Move()
            {
                Console.WriteLine("Vehicle is moving..");
            }
            public void Stop()
            {
                Console.WriteLine("Vehicle is stopping..");
            }
            public void Honk()
            {
                Console.WriteLine("Vehicle is honking..");
            }
        }

        class Animal : Inheritance //hierarchial
        {
            public string name;
            public string species;

            public void Run() 
            {
                Console.WriteLine("Animal is running");
            }
            public void Eat() 
            {
                Console.WriteLine("Animal is eating");
            }
        }

        class Dog : Animal //multilevel
        {
            public string breed;
            public int age;

            public void Bark()
            {
                Console.WriteLine("Dog is barking");
            }
            public void Run()
            {
                Console.WriteLine("Dog is running");
            }
        }

        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.PerformFunction();
            Animal animal = new Animal();
            animal.PerformFunction();
            animal.Run();
            Dog dog = new Dog();
            dog.PerformFunction();
            dog.Bark();
            dog.Eat();
            dog.Run();

        }
    }
}
