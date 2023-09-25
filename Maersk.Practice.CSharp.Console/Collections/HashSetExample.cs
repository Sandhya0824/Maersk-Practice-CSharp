using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class HashSetExample
    {
        public static void Main(string[] args)
        { 
            var names = new HashSet<string>();
            names.Add("Eena");
            names.Add("Meena");
            names.Add("Deeka");
            names.Add("Shakira");
            names.Add("Meena");//will not be added because it is duplicate 
            names.Add("Cardi B");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Remove("Deeka");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Contains("Justin");
            names.Contains("Deeka");
            names.Contains("Eena");

            names.RemoveWhere(names.Contains);
        }
    }
}
