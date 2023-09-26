using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.Console.Collections
{
    public class ListExample
    {
        public static void Main(string[] args)
        {
            //Example 1
            List<int> firstList = new List<int>();
            System.Console.WriteLine("Display the number of elements of List<T>: "+firstList.Count);

            firstList.Add(1); //Example of Add() method.
            firstList.Add(2);
            firstList.Add(3);
            firstList.Add(4);
            System.Console.WriteLine("Capacity Is: " + firstList.Capacity);
            System.Console.WriteLine("Count Is: " + firstList.Count);

            firstList.Add(5);
            firstList.Add(6);

            // Printing the Capacity of firstlist. It will give output 8 as internally list is resized
            //  (the current implementation detail will double it's backing store)
            System.Console.WriteLine("Capacity Is: " + firstList.Capacity); // Example of Capacity()

            System.Console.WriteLine("Count Is: " + firstList.Count); //Example of Count()

            System.Console.WriteLine();
            //Example 2
            var names = new List<string>();
            names.Add("Aakriti Kumari");
            names.Add("Manaswini Ray");
            names.Add("Sandhya Rani");

            foreach(var name in names)
            {
                System.Console.WriteLine(name);
            }
            System.Console.WriteLine();


            //Example 3
            var internsName = new List<string>() { "Aakriti", "Manaswini", "Sandhya"};
            foreach(var interns in internsName)
            {
                System.Console.WriteLine(interns);
            }


            //Example of AddRange(IEnumerable<T>)
            System.Console.WriteLine("\nAddRange(internsName)");
            internsName.AddRange(internsName);

            System.Console.WriteLine();
            foreach(var internName in internsName)
            {
                System.Console.WriteLine(internName);
            }

            //Example of RemoveRange(Int 32, Int 32)
            System.Console.WriteLine("\nRemoveRange(2,2)");
            internsName.RemoveRange(2, 2);

            System.Console.WriteLine();
            foreach (var internName in internsName)
            {
                System.Console.WriteLine(internName);
            }

            


            //Example of CopyTo() method of List<T>
            List<string> dinosaurs = new List<string>();

            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Brachiosaurus");
            dinosaurs.Add("Compsognathus");

            System.Console.WriteLine();
            System.Console.WriteLine("List of dinosaurs");
            foreach (string dinosaur in dinosaurs)
            {
                System.Console.WriteLine(dinosaur);
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

            System.Console.WriteLine("\nContents of the array:");
            foreach (string dinosaur in array)
            {
                System.Console.WriteLine(dinosaur);
            }


            //Example of InsertRange()
            System.Console.WriteLine("\nInsertRange(3,internsName)");
            dinosaurs.InsertRange(3, internsName);

            System.Console.WriteLine();
            foreach(string dinosaur in dinosaurs)
            {
                System.Console.WriteLine(dinosaur);
            }
        }
    }
}
