using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class Constructor
    {
        int num;
        string name;
        static Constructor()
        {
            Console.WriteLine("This is static constructor");
        }
        Constructor() //Default Constructor
        {
            Console.WriteLine("Constructor called");
        }
        Constructor(string name, int num) //Parameterized Constructor
        {
            this.name = name;
            this.num = num;
        }
        Constructor(Constructor s) //Copy Constructor
        {
            name = s.name;
            num = s.num;
        }
        /*private Constructor() //private Constructor
        {
        }*/
        
        public static void Main()
        {
            Constructor c = new Constructor(); //Default Constructor
            Console.WriteLine(c.name);//It will give null
            Console.WriteLine(c.num);//It will give 0
            Constructor c1 = new Constructor("Aakriti", 01); //Parameterized Constructor
            Console.WriteLine(c1.name + " " + c1.num);
            Constructor c2 = new Constructor(c1);
            Console.WriteLine(c1.name + " " + c1.num); //Copy Constructor
        }
    }
}
