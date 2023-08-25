using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class Constructor
    {
        String name;
        String breed;
        int age;
        String color;

        public Constructor(String name, String breed, int age, String color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public String GetName()
        {
            return name;
        }

        public String GetBreed()
        {
            return breed;
        }

        public int GetAge()
        {
            return age;
        }

        public String GetColor()
        {
            return color;
        }

        public String Display()
        {
            return ("Hi my name is " + this.GetName()
                    + ". My breed, age and color are " + this.GetBreed()
                    + ", " + this.GetAge() + " and " + this.GetColor());
        }

        public static void Main(String[] args)
        {
            Constructor dog = new Constructor("Oreo", "Golden Retreiver", 5, "Golden");
            Console.WriteLine(dog.Display());
        }
    }
}
