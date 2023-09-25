using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Generics
{
    internal class ImplementingStackUsingList
    {
        public class Stack<T>
        {
            private List<T> items = new List<T>();

            public void Push(T item)
            {
                items.Add(item);
            }

            public T Pop()
            {
                if (items.Count == 0)
                    throw new InvalidOperationException("Stack is empty");

                int lastIndex = items.Count - 1;
                T poppedItem = items[lastIndex];
                items.RemoveAt(lastIndex);
                return poppedItem;
            }

            public int Count()
            {
                return items.Count;
            }
        }

        class Program
        {
            static void Main()
            {
                Stack<int> intStack = new Stack<int>();
                intStack.Push(10);
                intStack.Push(20);
                intStack.Push(30);

                Console.WriteLine("Integer Stack:");
                while (intStack.Count() > 0)
                {
                    int item = intStack.Pop();
                    Console.WriteLine(item);
                }

                Stack<string> stringStack = new Stack<string>();
                stringStack.Push("Sandy");
                stringStack.Push("Manu");
                stringStack.Push("Aakhri");

                Console.WriteLine();
                Console.WriteLine("String Stack:");
                while (stringStack.Count() > 0)
                {
                    string item = stringStack.Pop();
                    Console.WriteLine(item);
                }
            }
        }
    }
}
