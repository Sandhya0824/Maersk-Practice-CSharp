using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{

    class Employee
    {
        private static int count;           //static property
        public String name=" ";             //public property
        private int salary;                 //private property
        public Employee() { count++; }

        public static int Count { get { return count; } }   //static property

        public Employee(string name)
        {
            this.name = name;
        }

        public int Salary { get { return salary; } set {  salary = value; } }   //accessors
        public string Name { get { return name; } }
    }
    internal class Properties
    {

        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();

            Employee employee4 = new Employee("Ram");
            employee3.name = "Ram";
            employee3.Salary = 100;
            Console.WriteLine("Employee Name: " + employee3.Name + " Employee Salary:" + employee3.Salary);

            Console.WriteLine("Employee Count : "+Employee.Count);
        }
    }
}
