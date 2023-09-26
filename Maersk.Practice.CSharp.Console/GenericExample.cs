using C__Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.Console
{
    //Multiple type parameters in generics example
    public class GenericExample1
    {
        //Generic Method
        public void Display<TypeOfValue>(string message, TypeOfValue value)
        {
            System.Console.WriteLine("{0}:{1}",message,value);
        }
    }

    //User defined generics class
    public class GenericExample2<T>
    { 
        private T data; //private data members

        public T value //using properties
        {
            get 
            { 
                return this.data; 
            } 
            set 
            {
                this.data = value;
            } 
        }
    }
    public class GenericExample
    {
        public static void Main(string[] args) 
        {
            GenericExample1 example1 = new GenericExample1();
            example1.Display<int>("Integer type", 14);
            example1.Display<char>("Character type", 'A');
            example1.Display<double>("Double type", 14.04);

            GenericExample2<string> name = new GenericExample2<string>();
            name.value = "Aakriti";

            GenericExample2<float> salary = new GenericExample2<float>();
            salary.value = 50000.0F;

            System.Console.WriteLine("Name of employee: "+name.value);
            System.Console.WriteLine("Salary of employee: "+salary.value);
        }
    }
}
