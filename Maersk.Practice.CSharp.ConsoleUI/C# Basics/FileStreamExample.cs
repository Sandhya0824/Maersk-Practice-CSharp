using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.C__Basics
{
    public class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Dev\\FileExample", FileMode.OpenOrCreate);//creating file stream  
            f.WriteByte(65);//writing byte into stream  
            f.Close();//closing stream  
        }
    }
}
