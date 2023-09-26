using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.Generics
{
    internal class GenericsBasic
    {
        public void Show<T>(T msg)
        {
            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            GenericsBasic gen = new GenericsBasic();
            gen.Show("This is generic method");
            gen.Show(101);
            gen.Show('I');
            gen.Show(true);
        }
    }
}
