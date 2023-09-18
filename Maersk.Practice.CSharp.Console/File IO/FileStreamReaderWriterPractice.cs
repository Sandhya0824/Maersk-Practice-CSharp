using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Maersk.Practice.CSharp.ConsoleUI
{
    internal class FileStreamPractice
    {
        public static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("C:\\Interns.Maersk.Practice\\Maersk-Practice-CSharp\\practice.txt", FileMode.OpenOrCreate);
            byte value = 65;                //writing bytes into the file
            fileStream.WriteByte(value);

            for(int i = 65;i <= 90; i++)
            {
                fileStream.WriteByte((byte)i);
            }

            int j = 0;

            while((j=fileStream.ReadByte())!= -1)
            {
                System.Console.Write((char)j);
            }

            System.Console.Out.Flush();
            fileStream.Close();

            
        }
    }
}
