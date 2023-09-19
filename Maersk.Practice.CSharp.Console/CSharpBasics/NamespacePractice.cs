using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    class NamespacePractice
    {
        public static void Main(string[] args)
        {
            first.Geeks_1.display();
            Check.NamespacePractice.play();
        }
    }
}

namespace Check
{
    class NamespacePractice
    {
        public static void play() { }
    }
}

