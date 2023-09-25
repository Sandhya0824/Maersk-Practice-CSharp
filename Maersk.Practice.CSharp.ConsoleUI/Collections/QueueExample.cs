using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class QueueExample
    {
        public static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Sandy");
            names.Enqueue("Andy");
            names.Enqueue("Mandy");
            names.Enqueue("Randy");
            names.Enqueue("Handy");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.TryDequeue(out string res);
            Console.WriteLine(res);

            names.Clear();
            names.TryDequeue(out string res2);
            Console.WriteLine(res2);
        }
    }
}
