using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.File_IO
{
    internal class FileInfoReaderWriterPractice
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Interns.Maersk.Practice\\Maersk-Practice-CSharp\\fileInfoPractice.txt";

            FileInfo fileInfo = WriteFile(path);
            System.Console.WriteLine(ReadFile(path, fileInfo));
            
        }

        public static FileInfo WriteFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            StreamWriter streamWriter = fileInfo.CreateText();

            streamWriter.WriteLine("Hello FileInfo it is!");

            streamWriter.Close();

            return fileInfo;
        }

        public static string ReadFile(string path, FileInfo fileInfo)
        {
            StreamReader streamReader = fileInfo.OpenText();
            string line = "";
            while(streamReader.ReadToEnd() != line)
            {
                return line;
            }
            return null;
        }
    }
}
