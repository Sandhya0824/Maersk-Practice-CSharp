using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.Collections
{
    public class ListExample
    {
        public static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            Console.WriteLine("Display the number of elements of List<T>: "+firstList.Count);

            firstList.Add(1);
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            Console.WriteLine("Capacity Is: " + firstList.Capacity);
            Console.WriteLine("Count Is: " + firstList.Count);

            firstList.Add(5);
            firstList.Add(6);
            // Printing the Capacity of firstlist. It will give output 8 as internally list is resized
            // (the current implementation detail will double it's backing store)
            Console.WriteLine("Capacity Is: " + firstList.Capacity);
            Console.WriteLine("Count Is: " + firstList.Count);

            var names = new List<string>();
            names.Add("Aakriti Kumari");
            names.Add("Manaswini Ray");
            names.Add("Sandhya Rani");

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            var internsName = new List<string>() { "Aakriti", "Manaswini", "Sandhya"};
            foreach(var interns in internsName)
            {
                Console.WriteLine(interns);
            }
        }
    }
}
