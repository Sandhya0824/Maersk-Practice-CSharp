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
            string sourcePath = "C:\\Interns.Maersk.Practice\\Maersk-Practice-C-Sharp\\Maersk-Practice-CSharp\\fileInfoPractice.txt";
            string targetPath = "C:\\Interns.Maersk.Practice\\Maersk-Practice-C-Sharp\\Maersk-Practice-CSharp\\fileInfoPractice2.txt";

            FileInfo fileInfo = new FileInfo(sourcePath);
            FileInfo fileInfo2 = new FileInfo(sourcePath);


            System.Console.WriteLine(FileLength(fileInfo2));
        }

        public static void FileDelete(FileInfo fileInfo)
        {
            fileInfo.Delete();
        }

        public static string DirectoryName(FileInfo fileInfo)
        {
            return fileInfo.DirectoryName;
        }

        public static bool FileExists(FileInfo fileInfo)
        {
            return fileInfo.Exists;
        }

        public static string FileExtension(FileInfo fileInfo)
        {
            return fileInfo.Extension;
        }

        public static long FileLength(FileInfo fileInfo)
        {
            return fileInfo.Length;
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
