using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    //Super/Base Class
    public class Human
    {
        public void Eat()
        {
            System.Console.WriteLine("Human Eats");
        }
    }

    //Single Inheritance
    class Teacher : Human
    {
        public void Teach()
        {
            System.Console.WriteLine("Teacher Teaches");
        }
    }

    //Multilevel Inheritance
    class SecondaryChild : Teacher
    {
        public void Study()
        {
            System.Console.WriteLine("Child Studies Secondary Things");
        }
    }

    class PrimaryChild : SecondaryChild
    {
        public void StudyChild()
        {
            System.Console.WriteLine("Child Studies Primary Things");
        }
    }

    //Hierarchial Inheritance
    class Worker : Human
    {
        public void Works()
        {
            System.Console.WriteLine("Worker works");
        }
    }

    class Labour : Human
    {
        public void Labours()
        {
            System.Console.WriteLine("Human do labours");
        }
    }

    //Multiple Inheritance

    interface I1
    {
        void Interface1();
    }

    interface I2
    {
        void Interface2();

    }

    class CheckInheritance : I1, I2
    {
        public void Interface1()
        {
            System.Console.WriteLine("In Interface 1");
        }
        public void Interface2()
        {
            System.Console.WriteLine("In Interface 2");
        }
    }



    internal class Inheritance
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Single Level Inheritance");
            Teacher teacher = new Teacher();
            teacher.Eat();
            teacher.Teach();

            System.Console.WriteLine();
            System.Console.WriteLine("Multilevel Inheritance");
            PrimaryChild child = new PrimaryChild();
            child.Eat();
            child.Teach();
            child.Study();
            child.StudyChild();

            System.Console.WriteLine();
            System.Console.WriteLine("Hierarchial Inheritance");
            Worker worker = new Worker();
            worker.Works();
            worker.Eat();

            System.Console.WriteLine();
            System.Console.WriteLine("Multilevel Inheritance");
            CheckInheritance checkInheritance = new CheckInheritance();
            checkInheritance.Interface1();
            checkInheritance.Interface2();
        }
    }
}
