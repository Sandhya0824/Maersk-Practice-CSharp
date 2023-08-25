using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    //Super/Base Class
    public class Human
    {
        public void Eat()
        {
            Console.WriteLine("Human Eats");
        }
    }

    //Single Inheritance
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("Teacher Teaches");
        }
    }

    //Multilevel Inheritance
    class SecondaryChild: Teacher
    {
        public void Study()
        {
            Console.WriteLine("Child Studies Secondary Things");
        }
    }

    class PrimaryChild : SecondaryChild
    {
        public void StudyChild() 
        {
            Console.WriteLine("Child Studies Primary Things");
        }
    }

    //Hierarchial Inheritance
    class Worker : Human
    {
       public void Works()
        {
            Console.WriteLine("Worker works");
        }
    }

    class Labour : Human
    {
        public void Labours()
        {
            Console.WriteLine("Human do labours");
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
            Console.WriteLine("In Interface 1");
        }
        public void Interface2()
        {
            Console.WriteLine("In Interface 2");
        }
    }
    


    internal class Inheritance
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Single Level Inheritance");
            Teacher teacher = new Teacher();
            teacher.Eat();
            teacher.Teach();

            Console.WriteLine();
            Console.WriteLine("Multilevel Inheritance");
            PrimaryChild child = new PrimaryChild();
            child.Eat();
            child.Teach();
            child.Study();
            child.StudyChild();

            Console.WriteLine();
            Console.WriteLine("Hierarchial Inheritance");
            Worker worker = new Worker();
            worker.Works();
            worker.Eat();

            Console.WriteLine();
            Console.WriteLine("Multilevel Inheritance");
            CheckInheritance checkInheritance = new CheckInheritance();
            checkInheritance.Interface1();
            checkInheritance.Interface2();
        }
    }
}
