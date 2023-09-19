using C_SharpLearning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Maersk.Practice.CSharp.ConsoleUI
{
    [Serializable]
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    internal class SerializationAndDeserialization
    {
        public static void Main(string[] args)
        {
            string path = "C:\\Interns.Maersk.Practice\\Maersk-Practice-CSharp\\serializationAndDeserializationPractice.txt";

            try
            {
                Serialization(path);

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
        }

        public static void Serialization(string path)
        {
         /*   using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(); 

                Employee employee = new Employee(1011, "Ram");
                binaryFormatter.Serialize(fileStream, employee);
                fileStream.Close();
            } */
           
        }
    }

    /*  Serialization is quite important as it saves the state of the object 
      so that it can be recovered or recreated as and when it is required. 
      This means that the object can be transferred to any remote location 
      as required using a web service by transferring the object from one domain to another.

      */

    //It takes simple data structures such as integers (int), decimal numbers (float),
    //and collections of letters and numbers (string)
    //and can convert them into a binary format.


}
