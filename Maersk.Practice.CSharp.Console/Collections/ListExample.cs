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
