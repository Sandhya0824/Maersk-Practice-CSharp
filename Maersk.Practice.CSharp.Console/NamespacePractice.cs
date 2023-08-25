using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_SharpLearning;


namespace NamespacePracticeMain{
    class NamespacePractice
    {
        public static void Main(String[] args) 
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

