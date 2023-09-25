using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class ListExample
    {
        public static void Main(string[] args)
        {  
            var names = new List<string>();
            names.Add("Sandhya");
            names.Add("Manaswini");
            names.Add("Aakriti");
            names.Add("Harsh");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


            var names1 = new List<string>() {"Sandhya", "Manaswini", "Aakriti", "Sidd"};
  
            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }


            names1.Remove("Sandhya");
            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }
        }
    }
}
