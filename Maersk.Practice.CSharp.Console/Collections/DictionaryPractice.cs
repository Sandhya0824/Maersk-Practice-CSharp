using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class DictionaryPractice
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Ram");
            dictionary.Add(5, "Vikram");
            dictionary.Add(2, "Shyam");
            dictionary.Add(4, "Aayesha");
            dictionary.Add(3, "Sita");

            System.Console.WriteLine("Key-Value Pairs : ");
            foreach(KeyValuePair<int, string> item in dictionary)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Keys: ");
            foreach(KeyValuePair<int, string> item in dictionary)
            {
                System.Console.WriteLine(item.Key);
            }

            System.Console.WriteLine("Values: ");
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                System.Console.WriteLine(item.Value);
            }

            System.Console.WriteLine("Value: {0}", dictionary[2]);

            System.Console.WriteLine("Using for loop");
            for(int i=0; i<dictionary.Count; i++)
            {
                System.Console.WriteLine("{0} --> {1}", dictionary.Keys.ElementAt(i), dictionary[dictionary.Keys.ElementAt(i)]);
            }

            System.Console.WriteLine(dictionary.ContainsKey(2));
            System.Console.WriteLine(dictionary.ContainsValue("Ram"));
        }
    }
}
