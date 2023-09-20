using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class HashSet
    {
        public static void Main(string[] args)
        {
            HashSet<int> hashSet = new HashSet<int>();

            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(4);
            hashSet.Add(5);
            hashSet.Add(1);

            HashSet<int> hashSet2 = new HashSet<int>();

            hashSet2.Add(7);
            hashSet2.Add(8);
            hashSet2.Add(9);

            System.Console.WriteLine("Union");
            hashSet2.UnionWith(hashSet);
            foreach (int i in hashSet2)
            {
                System.Console.WriteLine(i);
            }

            HashSet<int> hashSet3 = new HashSet<int>();

            hashSet3.Add(2);
            hashSet3.Add(3);
            hashSet3.Add(4);

            System.Console.WriteLine("Intersect");
            hashSet3.IntersectWith(hashSet);
            foreach (int i in hashSet3)
            {
                System.Console.WriteLine(i);
            }


            HashSet<int> hashSet4 = new HashSet<int>();

            hashSet4.Add(2);
            hashSet4.Add(3);
            hashSet4.Add(4);

            System.Console.WriteLine("Except");
            hashSet4.ExceptWith(hashSet);
            foreach (int i in hashSet)
            {
                System.Console.WriteLine(i);
            }

        }
    }
}
