using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.FileIO
{
    internal class SerializationandDeserializationExample
    {
        public class Student
        {
            string name;
            int rollNo;
            double marks;
            public Student(string name, int rollNo, double marks)
            {
                this.name = name;
                this.rollNo = rollNo;
                this.marks = marks;
            }

            public static void Main(string[] args)
            {
                FileStream stream = new FileStream("C:\\Dev\\FileExample\\ex6.txt", FileMode.OpenOrCreate);
                BinaryFormatter formatter = new BinaryFormatter();

                Student s = new Student("Sandhya", 8048, 9.2);
                //formatter.Serialize(stream, s);

                /*Student s2 = (Student)formatter.Deserialize(stream);

                Console.WriteLine("Name: " + s2.name);
                Console.WriteLine("Rollno: " + s2.rollNo);
                Console.WriteLine("Marks: " + s2.marks);
                */

                stream.Close();
            }
        }
    }
}
