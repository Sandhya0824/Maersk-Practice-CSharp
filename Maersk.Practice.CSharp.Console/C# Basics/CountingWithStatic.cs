using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class CountingWithStatic
    {
        public int accno;
        public String name;
        public static int count = 0;
        public CountingWithStatic(int accno, String name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }

        public void display()
        {
            Console.WriteLine(accno + " " + name);
        }
    
        public static void Main(string[] args)
        {
            CountingWithStatic a1 = new CountingWithStatic(1001, "Sandhya");
            CountingWithStatic a2 = new CountingWithStatic(1002, "Manaswini");
            CountingWithStatic a3 = new CountingWithStatic(1003, "Aakriti");
            CountingWithStatic a4 = new CountingWithStatic(1004, "Khushi");
            a1.display();
            a2.display();
            a3.display();
            a4.display();
            Console.WriteLine("Total Objects are: " + CountingWithStatic.count);
        }
    }
}
