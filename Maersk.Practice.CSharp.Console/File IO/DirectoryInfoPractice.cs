using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.File_IO
{
    internal class DirectoryInfoPractice
    {
        public static void Main(string[] args)
        {
            string sourcePath = "C:\\Interns.Maersk.Practice\\Maersk-Practice-C-Sharp\\Maersk-Practice-CSharp\\DirectoryInfoPractice";
            DirectoryInfo directoryInfo = new DirectoryInfo(sourcePath);

            CreateDirectory(directoryInfo);

            FileInfo[] directoryInfos=GetFiles(directoryInfo);
            foreach(FileInfo directoryInfo1 in directoryInfos)
            {
                System.Console.WriteLine(directoryInfo1);
            }
        }

        public static void CreateDirectory(DirectoryInfo directoryInfo)
        {
            directoryInfo.Create();
        }

        public static void DeleteDirectory(DirectoryInfo directoryInfo)
        {
            directoryInfo.Delete();
        }

        public static bool DirectoryExists(DirectoryInfo directoryInfo)
        {
            return directoryInfo.Exists;
        }

        public static string DirectoryFullName(DirectoryInfo directoryInfo)
        {
            return directoryInfo.FullName;
        }

        public static DirectoryInfo[] GetDirectories(DirectoryInfo directoryInfo)
        {
            DirectoryInfo[] directories = directoryInfo.GetDirectories();
            return directories;
        }

        public static FileInfo[] GetFiles(DirectoryInfo directoryInfo)
        {
            FileInfo[] files = directoryInfo.GetFiles();
            return files;
        }

    }
}
