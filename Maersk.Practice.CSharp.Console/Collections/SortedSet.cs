using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class SortedSet
    {
        public static void Main(string[] args)
        {
            SortedSet<string> sortedSet = new SortedSet<string>();

            sortedSet.Add("A");
            sortedSet.Add("B");
            sortedSet.Add("C");
            sortedSet.Add("D");
            sortedSet.Add("E");
            sortedSet.Add("B");

            foreach (string item in sortedSet)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
