using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class SortedSetExample
    {
        public static void Main(string[] args)
        { 
            var names = new SortedSet<string>();
            names.Add("Sandy");
            names.Add("Manu");
            names.Add("Aakhri");
            names.Add("Harsh");
            names.Add("Manu");//will not be added due to duplicacy 
            names.Add("Sidd");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine(names.Contains("Sidd")); 

            Console.WriteLine();

            names.Remove("Sandy");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            Console.WriteLine(names.Contains("Aaloo"));

            Console.WriteLine();

            names.Remove("Rohan");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            names.RemoveWhere(names.Contains);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
