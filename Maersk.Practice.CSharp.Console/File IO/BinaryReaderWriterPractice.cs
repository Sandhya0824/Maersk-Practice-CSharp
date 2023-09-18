using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI
{
    internal class BinaryReaderWriterPractice
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Interns.Maersk.Practice\\Maersk-Practice-CSharp\\textPractice.txt";

            WriteBinaryFile(path);
            ReadBinaryFile(path);
        }

        public static void WriteBinaryFile(string path)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(path,FileMode.Create)))
            {
                binaryWriter.Write(true);
                binaryWriter.Write(8.9);
                binaryWriter.Write("All the details");
            }
        }

        public static void ReadBinaryFile(string path)
        {
            using(BinaryReader binaryReader=new BinaryReader(File.Open(path,FileMode.Open)))
            {
                System.Console.WriteLine(binaryReader.ReadBoolean());
                System.Console.WriteLine(binaryReader.ReadDouble());
                System.Console.WriteLine(binaryReader.ReadString());

            }
        }
    }

    
}
