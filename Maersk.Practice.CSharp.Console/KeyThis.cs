using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    //Using ‘this’ keyword to refer current class instance members
    public class Example
    {
        public string Name;
        public string GetName()
        {
            return Name;
        }
        public void SetName(string Name)
        {
            //"this.Name" refers to class member
            this.Name = Name;
        }
    }
    // Using ‘this’ keyword to invoke current class method 
    public class Example1
    {
        public void display()
        {
            this.show();
            Console.WriteLine("Inside display function");
        }
        public void show()
        {
            Console.WriteLine("Inside show function");
        }
    }
    //Using ‘this’ keyword as method parameter
    public class Example2
    {
        int a, b;
        public Example2()
        {
            a = 10;
            b = 11;
        }
        public void display2(Example2 t2)
        {
            Console.WriteLine("a = " + a + " b = " + b);
        }
        public void get()
        {
            display2(this);
        }
    }
    //Using this keyword to declare an indexer
    public class Example3
    {
        private string[] days = new string[3];
        public string this[int index]
        {
            get
            {
                return days[index];
            }
            set
            {
                days[index] = value;
            }
        }

    }
    //Using this() to invoke the constructor in same class
    public class Example4
    {
        public Example4() : this("geeks")
        {
            Console.WriteLine("Non-Parameter Constructor Called");
        }
        public Example4(string Name)
        {
            Console.WriteLine("Parameter Constructor Called");
        }
    }
    public class KeyThis
    {
        public static void Main(string[] args)
        {
            Example t = new Example();//Using ‘this’ keyword to refer current class instance members
            t.SetName("Aakriti");
            Console.WriteLine(t.GetName());

            Example1 t1 = new Example1();// Using ‘this’ keyword to invoke current class method 
            t1.display();
    
            Example2 t2 = new Example2();//Using ‘this’ keyword as method parameter
            t2.get();

            Example3 t3 = new Example3();//Using this keyword to declare an indexer
            t3[0] = "Sun";
            t3[1] = "Mon";
            t3[2] = "Tue";
            for (int i = 0; i < 3; i++)
            {
                Console.Write(t3[i] + " ");
            }
            Console.WriteLine();

            Example4 t4 = new Example4();//Using this() to invoke the constructor in same class





        }
    }
}
