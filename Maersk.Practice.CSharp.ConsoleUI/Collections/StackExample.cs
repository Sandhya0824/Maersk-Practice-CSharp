using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class StackExample
    {
        public static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("Sandy");
            names.Push("Manu");
            names.Push("Aakhri");
            names.Push("Harsh");
            names.Push("Sidd");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop, Peek element: " + names.Peek());
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            names.Clear();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


        }
    }
}
