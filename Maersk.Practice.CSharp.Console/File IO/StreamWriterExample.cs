using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace C__Basics.File_IO
{
    public class StreamWriterExample
    {
        public static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"D:\FileStream\FileIO.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Hello! This code is for stream writer in C#.");
            streamWriter.Close();
            fileStream.Close();
            Console.WriteLine("File created successfully");
        } 
    }
}
