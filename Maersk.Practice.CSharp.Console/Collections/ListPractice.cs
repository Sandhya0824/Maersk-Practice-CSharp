using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Collections
{
    internal class ListPractice
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Ram");
            list.Add("Shyam");
            list.Add("Sita");
            list.Add("Gita");
            list.Add("Laxman");
            

            System.Console.WriteLine(list.Capacity);
            System.Console.WriteLine(list.Count);

            System.Console.WriteLine(list.Contains("Ram"));

            foreach (string item in list)
            {
                System.Console.WriteLine(item);
            }System.Console.WriteLine();

            list.Sort();
            foreach (string item in list)
            {
                System.Console.WriteLine(item);
            }System.Console.WriteLine() ;

            int index = list.BinarySearch("Helena");

            System.Console.WriteLine(index);

            if(index < 0)
            {
                list.Insert(~index, "Helena");
            }
            foreach (string item in list)
            {
                System.Console.WriteLine(item);
            }System.Console.WriteLine('\n');
        }
    }
}
