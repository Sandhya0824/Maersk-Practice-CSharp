using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.File_IO
{
    internal class FileClassPractice
    {
        public static void Main(string[] args)
        {
            string sourcePath = "C:\\Interns.Maersk.Practice\\Maersk-Practice-C-Sharp\\Maersk-Practice-CSharp\\FileClassPractice.txt";
            string targetPath = "C:\\Interns.Maersk.Practice\\Maersk-Practice-C-Sharp\\Maersk-Practice-CSharp\\FileClassPractice2.txt";

            System.Console.WriteLine(GetCreationTime(sourcePath));
            
        }

        public static DateTime GetCreationTime(string path)
        {
            return File.GetCreationTime(path);
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public static void Delete(string path)
        {
            File.Delete(path);
        }

        public static void Copy(string sourcePath, string targetPath)
        {
            File.Copy(sourcePath, targetPath, true);
        }

        public static void WriteAllText(string path)
        {
            string data = "Hello! Welcome to Maersk";

            File.WriteAllText(path, data);
        }

        public static string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        public static void WriteAllLines(string path)
        {
            string[] data = { "Hello", "my", "name", "is", "Manaswini", "Ray" };

            File.WriteAllLines(path, data);
        }

        public static string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public static byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public static void AppendAllText(string path)
        {
            string data = "The work culture is very sophisticated";

            File.AppendAllText(path, data);
        }

        public static void AppendAllLines(string path)
        {
            string[] data = { "The", "work", "culture", "is", "very", "sophisticated" };

            File.AppendAllLines(path, data);
        }


    }
}
