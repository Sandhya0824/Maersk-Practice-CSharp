using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.FileIO
{
    internal class StringReaderWriterExample
    {
        public static void Main(string[] args)
        {
            string str = "Hello, I am Sandhya. \n" + "I am a 4th year student. \n" + "I am working as an intern at Maersk. ";

            StringBuilder sb = new StringBuilder();
            
            StringWriter writer = new StringWriter(sb);
            
            writer.WriteLine(str);
            writer.Dispose();
            writer.Close();

            StringReader reader = new StringReader(sb.ToString()); 
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
