using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.Console.Collections
{
    public class HashSetExample
    {
        public static void Display(IEnumerator<int> enumerator)
        {
            System.Console.WriteLine("Getting an enumerator for the naturalNumber hashset.");
            while (enumerator.MoveNext())
            {
                int val=enumerator.Current;
                System.Console.Write(val+" ");
            }
        }
        public static void Main(string[] args)
        {
            HashSet<int> oddElement = new HashSet<int>();

            System.Console.WriteLine("Odd Elements:");
            //Inserting odd elements in HashSet
            for (int i = 0; i < 5; i++)
            {
                oddElement.Add(2 * i + 1);
            }

            //Displaying the odd elements in the HashSet
            foreach (int i in oddElement)
            {
                System.Console.WriteLine(i);
            }
            // To get the number of elements that are contained in HashSet
            System.Console.WriteLine("Number of odd elements that are contained in HashSet: " + oddElement.Count);

            HashSet<int> evenElement = new HashSet<int>();

            System.Console.WriteLine("Even Elements:");
            //Inserting even elements in HashSet
            for (int i = 0; i < 5; i++)
            {
                evenElement.Add(2 * i);
            }

            //Displaying the even elements in the HashSet
            foreach (int i in evenElement)
            {
                System.Console.WriteLine(i);
            }
            // To get the number of elements that are contained in HashSet
            System.Console.WriteLine("Number of even elements that are contained in HashSet: " + evenElement.Count);

            System.Console.WriteLine("Check whether evenElement hashset is subset of oddElement hashset: "+evenElement.IsSubsetOf(oddElement));


            //Check if a HashSet contains the specified element
            if (evenElement.Contains(3))
            {
                System.Console.WriteLine("Required element is present");
            }
            else
            {
                System.Console.WriteLine("Required element is not present");

            }

            //ExceptWith(IEnumerable) method example
            HashSet<int> naturalNumber = new HashSet<int>();
            for(int i = 0; i < 11; i++)
            {
                naturalNumber.Add(i);
            }
            System.Console.WriteLine("Before removing elements from naturalNumber hashset:");
            foreach (int i in naturalNumber)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();

            naturalNumber.ExceptWith(evenElement);
            
            System.Console.WriteLine("After removing elements from naturalNumber hashset:");
            foreach (int i in naturalNumber)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();


            //GetEnumerator() method example
            HashSet<int>.Enumerator enumerator = naturalNumber.GetEnumerator();
            Display(enumerator);
            System.Console.WriteLine();


            //IntersectionWith(IEnumerable) method example
            HashSet<int> intersectionHashSet = new HashSet<int>(naturalNumber);
            intersectionHashSet.IntersectWith(oddElement);
            System.Console.WriteLine("Getting the element common in oddElement and naturalNumber hashSet.");
            foreach (int i in intersectionHashSet)
            {
                System.Console.Write(i+" ");
            }
            System.Console.WriteLine();


            //UnionWith(IEnumerable) method example
            HashSet<int> unionHashSet = new HashSet<int>(naturalNumber);
            unionHashSet.UnionWith(evenElement);
            System.Console.WriteLine("Getting the union of oddElement and naturalNumber hashSet.");
            foreach (int i in unionHashSet)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();

            //IsProperSubsetOf(IEnumerable) method example
            System.Console.WriteLine("Is intersectionHashSet is a proper subset of naturalNumber: " + intersectionHashSet.IsProperSubsetOf(naturalNumber));
            System.Console.WriteLine("Is naturalNumber is a proper subset of intersectionHashSet: " + naturalNumber.IsProperSubsetOf(intersectionHashSet));


            //IsProperSupersetOf(IEnumerable) method example
            System.Console.WriteLine("Is intersectionHashSet is a superset of naturalNumber: " + intersectionHashSet.IsSupersetOf(naturalNumber));
            System.Console.WriteLine("Is naturalNumber is a superset of intersectionHashSet: " + naturalNumber.IsSupersetOf(intersectionHashSet));

        }
    }
}
