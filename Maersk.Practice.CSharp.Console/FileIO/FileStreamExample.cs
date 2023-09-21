using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.FileIO
{
    public class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Dev\\FileExample\\ex1.txt", FileMode.OpenOrCreate);
            f.WriteByte(65);  
            f.Close();

            FileStream f1 = new FileStream("C:\\Dev\\FileExample\\ex2.txt", FileMode.OpenOrCreate);
            for (int i = 65; i <= 90; i++)
            {
                f1.WriteByte((byte)i);
            }
            f1.Close();

            FileStream f2 = new FileStream("C:\\Dev\\FileExample\\ex2.txt", FileMode.OpenOrCreate);
            int j = 0;
            while ((j = f2.ReadByte()) != -1)
            {
                Console.Write((char)j);
            }
            f2.Close();
        }
    }
}
