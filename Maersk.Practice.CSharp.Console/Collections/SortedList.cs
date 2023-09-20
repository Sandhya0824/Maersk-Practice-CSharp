using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class SortedList
    {
        public static void Main(string[] args)
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();

            sortedList.Add(1, "Ram");
            sortedList.Add(5, "Vikram");
            sortedList.Add(2, "Shyam");
            sortedList.Add(4, "Aayesha");
            sortedList.Add(3, "Sita");

            System.Console.WriteLine("Key-Value Pairs : ");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Keys: ");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                System.Console.WriteLine(item.Key);
            }

            System.Console.WriteLine("Values: ");
            foreach (KeyValuePair<int, string> item in sortedList)
            {
                System.Console.WriteLine(item.Value);
            }

            System.Console.WriteLine("Value: {0}", sortedList[2]);

            System.Console.WriteLine("Using for loop");
            for (int i = 0; i < sortedList.Count; i++)
            {
                System.Console.WriteLine("{0} --> {1}", sortedList.Keys.ElementAt(i), sortedList[sortedList.Keys.ElementAt(i)]);
            }

            System.Console.WriteLine(sortedList.ContainsKey(2));
            System.Console.WriteLine(sortedList.ContainsValue("Ram"));


        }
    }
}
