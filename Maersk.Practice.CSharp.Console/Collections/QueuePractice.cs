using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class QueuePractice
    {
        public static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");
            queue.Enqueue("d");
            queue.Enqueue("e");

            System.Console.WriteLine( queue.Peek());

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }

            queue.Dequeue();

            foreach (var item in queue)
            {
                System.Console.WriteLine(item);
            }

        }

    }
}
