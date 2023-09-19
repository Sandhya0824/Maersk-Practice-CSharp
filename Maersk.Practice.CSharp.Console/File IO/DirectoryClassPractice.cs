using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.File_IO
{
    internal class DirectoryClassPractice
    {
        public static void Main(string[] args)
        {
            string sourcePath = "C:\\Interns.Maersk.Practice\\Maersk-Practice-C-Sharp\\Maersk-Practice-CSharp\\DirectoryPractice";

            CreateDirectory(sourcePath);

            string[] files= GetFiles(sourcePath);
            foreach (string file in files )
            {
                System.Console.WriteLine(file);
            }
        }

        public static bool DirectoryExists(string sourcePath)
        {
            return Directory.Exists(sourcePath);
        }

        public static string[] GetDirectories(string sourcePath)
        {
            string[] directories = Directory.GetDirectories(sourcePath);
            return directories;
        }

        public static string[] GetFiles(string sourcePath)
        {
            string[] files = Directory.GetFiles(sourcePath);
            return files;
        }

        public static void CreateDirectory(string path)
        {
            if(Directory.Exists(path))
            {
                System.Console.WriteLine("Directory already exists");
            }
            else
            {
                Directory.CreateDirectory(path);
                System.Console.WriteLine("Directory created succesfully");
            }
        }

        public static void DeleteDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                System.Console.WriteLine("Directory not exists");
            }
            else
            {
                Directory.Delete(path, true);
            }
        }



    }
}
