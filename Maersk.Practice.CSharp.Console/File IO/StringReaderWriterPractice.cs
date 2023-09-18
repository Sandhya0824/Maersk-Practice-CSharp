using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.File_IO
{
    internal class StringReaderWriterPractice
    {
        public static void Main(string[] args)
        {
            string text = "Hello " + "\nHope you doing well" + "\nEnjoy your life";

            StringBuilder stringBuilder = new StringBuilder();
            StringWriter stringWriter = new StringWriter(stringBuilder);

            stringWriter.WriteLine(text);

            stringWriter.Flush();
            stringWriter.Close();

            StringReader stringReader = new StringReader(stringWriter.ToString());
            while(stringReader.Peek() > -1)
            {
                System.Console.WriteLine(stringReader.ReadLine());
            }
        }

    }
}
