using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class StackPractice
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();

            System.Console.WriteLine(stack.Peek());

            foreach(int i in stack)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}
