using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics.File_IO
{
    public class FileStreamExample
    {
        public static void Main(string[] args)
        {
            FileStream fWrite = new FileStream(@"D:\FileStream\FileIO.txt", FileMode.Create, FileAccess.Write,FileShare.None);
            var text = "This is some text written to the textfile"+" named FileStream";

            //The Encoding.UTF8.GetBytes method is used to convert the text into a byte array. UTF-8 encoding is chosen for text encoding.
            byte[] writeArr = Encoding.UTF8.GetBytes(text);

            //0: This is the starting index within the writeArr array from which data should be read for writing.
            //In this case, it's the beginning of the writeArr array.

            //text.Length: This specifies the number of bytes to write from the writeArr array. It's based on the
            //length of the text string. It's important to note that text.Length represents the number of characters
            //in the string, and since the text is encoded in UTF-8, each character may be represented by multiple bytes.
            //So, this parameter indicates the number of bytes to write from the array.
            fWrite.Write(writeArr, 0, text.Length);
            fWrite.Close();

            FileStream fRead = new FileStream(@"D:\FileStream\FileIO.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            byte[] readArr = new byte[text.Length];
            int count;
            while((count = fRead.Read(readArr,0, readArr.Length)) > 0)
            {
                Console.WriteLine(Encoding.UTF8.GetString(readArr,0,count));
            }
            fRead.Close();

            //This line waits for a key press in the console, so the console window doesn't close immediately
            //after the program has finished executing. It allows you to see the output before the console window closes.
            Console.ReadKey();
        }
    }
}
