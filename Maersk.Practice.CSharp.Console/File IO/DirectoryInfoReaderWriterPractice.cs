using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.File_IO
{
    internal class DirectoryInfoReaderWriterPractice
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Interns.Maersk.Practice\\Maersk-Practice-CSharp\\directoryInfoPractice.txt";

            CreateDirectory(path);
            DeleteDirectory(path);
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
