using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.File_IO
{
    public class StreamReaderExample
    {
        public static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(@"D:\\FileIO.txt", FileMode.Create);
            StreamReader streamReader = new StreamReader(fileStream);

            string line = streamReader.ReadLine();
            Console.WriteLine(line);

            streamReader.Close();
            fileStream.Close();
        }
    }
}
