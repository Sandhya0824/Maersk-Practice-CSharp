using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class Params
    {
        public static void PrintObjects(params object[] objects)
        {
            foreach (object obj in objects)
            {
                Console.Write(obj + " ");
            }
        }

        public static void Main(string[] args)
        {
            PrintObjects("Sandy", 24, "Manaswini", 25, "Aakriti", 26, "Harsh", 8, 'i', true);
        }
    }
}
