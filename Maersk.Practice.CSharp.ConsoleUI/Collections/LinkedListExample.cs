using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class LinkedListExample
    {
        public static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Naman");
            names.AddLast("Pajash");
            names.AddLast("Takshu");
            names.AddLast("Nyru");
            names.AddFirst("Chhotu");
            names.AddFirst("Puchkii");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            var node = names.Find("Takshu");
            Console.WriteLine(node);
            names.AddBefore(node, "Tinnu");
            names.AddAfter(node, "Minnu");
            names.AddFirst("Puchkii");
            var node2 = names.FindLast("Puchkii");
            Console.WriteLine(node2);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
