using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
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
            //  (the current implementation detail will double it's backing store)
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



            //Example of CopyTo() method of List<T>
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Brachiosaurus");
            dinosaurs.Add("Compsognathus");

            Console.WriteLine();
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            // Declare an array with 15 elements.
            string[] array = new string[15];

            dinosaurs.CopyTo(array);//'array': This is the destination array where the elements will be copied. All the elements from the dinosaurs list will be copied to this array.
    
            //array: This is the destination array where the elements will be copied.
            //6: This is the starting index in the 'array' where the copied elements will be placed.It specifies the position in the 'array' where copying will start.
            dinosaurs.CopyTo(array, 6);

            //2: This is the starting index in the 'dinosaurs' list from which the copying will begin. In this case, it starts copying from the third element (indexes are zero-based).
            //'array': This is the destination array where the elements will be copied.
            //12: This is the starting index in the 'array' where the copied elements will be placed.It specifies the position in the 'array' where copying will start.
            //3: This is the number of elements to copy from the 'dinosaurs' list to the 'array'.
            dinosaurs.CopyTo(2, array, 12, 3);

            Console.WriteLine("\nContents of the array:");
            foreach (string dinosaur in array)
            {
                Console.WriteLine(dinosaur);
            }
        }
    }
}
