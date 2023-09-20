using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class LinkedListPractice
    {
        public static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            linkedList.AddFirst(-1);
            linkedList.AddFirst(-2);

            linkedList.Remove(-1);

            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            foreach (int i in linkedList)
            {
                System.Console.WriteLine(i);
            }

            System.Console.WriteLine(linkedList.Contains(5));
        }
    }
}
