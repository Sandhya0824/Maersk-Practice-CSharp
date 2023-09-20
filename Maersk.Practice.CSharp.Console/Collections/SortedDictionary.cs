using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class SortedDictionary
    {
        public static void Main(string[] args)
        {
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            sortedDictionary.Add(1, "Ram");
            sortedDictionary.Add(5, "Vikram");
            sortedDictionary.Add(2, "Shyam");
            sortedDictionary.Add(4, "Aayesha");
            sortedDictionary.Add(3, "Sita");

            System.Console.WriteLine("Key-Value Pairs : ");
            foreach (KeyValuePair<int, string> item in sortedDictionary)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Keys: ");
            foreach (KeyValuePair<int, string> item in sortedDictionary)
            {
                System.Console.WriteLine(item.Key);
            }

            System.Console.WriteLine("Values: ");
            foreach (KeyValuePair<int, string> item in sortedDictionary)
            {
                System.Console.WriteLine(item.Value);
            }

            System.Console.WriteLine("Value: {0}", sortedDictionary[2]);

            System.Console.WriteLine("Using for loop");
            for (int i = 0; i < sortedDictionary.Count; i++)
            {
                System.Console.WriteLine("{0} --> {1}", sortedDictionary.Keys.ElementAt(i), sortedDictionary[sortedDictionary.Keys.ElementAt(i)]);
            }

            System.Console.WriteLine(sortedDictionary.ContainsKey(2));
            System.Console.WriteLine(sortedDictionary.ContainsValue("Ram"));
        }
    }
}
