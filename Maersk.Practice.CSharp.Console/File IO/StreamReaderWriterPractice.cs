using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI
{
    internal class StreamReaderWriterPractice
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Interns.Maersk.Practice\\Maersk-Practice-CSharp\\streamPractice.txt";
            FileStream fileStream = new FileStream(path, FileMode.Create);
            
            StreamWriter streamWriter = new StreamWriter(fileStream);     //single line of data into the file
            streamWriter.WriteLine("Hello");

            StreamReader streamReader = new StreamReader(fileStream);
            string line = "";
            while ((line = streamReader.ReadLine()) != null)
            {
                System.Console.WriteLine(line); 
            }

            streamWriter.Close();
            streamReader.Close();
            fileStream.Close();
            
        }
    }
}
    