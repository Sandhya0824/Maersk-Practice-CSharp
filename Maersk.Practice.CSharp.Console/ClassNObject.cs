using C__Basics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
//Class example where Main is in another class.
{
    public class Student
    {
        public int id;
        public string name;
    }
    // Initialize and Display data through method and Store and
    // Display Employee Information
    public class Employee
    {
        public int id;
        public string name;
        public float salary;
        public void insert(int i, string n, float s)
        {
            id=i;
            name=n;
            salary=s;
         }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    public class ClassNObject
    {
        public static void Main(string[] args)
        {
            //In this example, Student is the type and s1 is the
            //reference variable that refers to the instance of
            //Student class. The new keyword allocates memory at
            //runtime.
            Student s1 = new Student();//creating an object of Student    
            s1.id = 101;
            s1.name = "Aakriti";
            Console.WriteLine("Student name n id: " + s1.name + " " + s1.id);
            Employee e1=new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            e1.insert(101, "Aakriti", 50000f);
            e2.insert(102, "Sandhya", 50000f);
            e3.insert(103, "Manaswini", 50000f);
            e1.display();
            e2.display();
            e3.display();

        }
    }
}
