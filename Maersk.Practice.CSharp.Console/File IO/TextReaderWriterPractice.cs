using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI
{
    internal class TextReaderWriterPractice
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Interns.Maersk.Practice\\Maersk-Practice-CSharp\\textPractice.txt";

            WriteTextFile(path);
            ReadTextFile(path);
     
        }

        public static void WriteTextFile(string path)
        {
            using (TextWriter textWriter = File.CreateText(path))       //multiple lines of data can be written
            {
                textWriter.WriteLine("Hello");
                textWriter.WriteLine("Welcome to Maersk!");
            }
        }

        public static void ReadTextFile(string path)
        {
            using (TextReader textReader = File.OpenText(path))
            {
                System.Console.WriteLine(textReader.ReadToEnd());
            }
        }
         
}
}
