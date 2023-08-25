namespace C_SharpLearning
{
    static class Person     //static class cannot be derived i.e sealed
    {
        static String Name;     //all members are declared as static

    }
    public class Student 
    {
        public int Id;
        public string Name;

        public static string School = "Kendriya Vidyalaya";

        public static int count=0;

        public Student() { Console.WriteLine("Default Constructor"); count++; }  //default constructor
        
        public void setDetails(int id, string name)     //parameterized constructor
        {
            Id = id;
            Name = name;
          
        }
       
        public Student(Student student)     //copy constructor
        {
            Id=student.Id;
            Name = student.Name;
            count++;
        }

        ~Student() { Console.WriteLine("Default Destructor"); }         //destructor

        public void display() 
        {
            Console.WriteLine("Id : "+ Id+ " Name : "+ Name+ " School : "+ School);
            this.msg();                 //this keyword to call methods
            this.msg(this);              //this keyword used as a parameter
        }

        public void msg()
        {
            Console.Write("Hello ");
        }
        public void msg(Student msg)
        {
            Console.WriteLine("Gaizzzzz");
        }

    }

    //private constructors doesn't allowto create instance for the classes and the static variables can be only used ClassName.variable.
    //static constructors can't be called and is automatically invoked when first reference of the object is made.
    class ClassAndObjects
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();     //new object new instance of the class
            s1.setDetails(1, "Ram");
            s1.display();

            Student s2 = new Student();
            s2.setDetails(2, "Sita");
            s2.display();

            Student s3 = new Student();
            s3 = s1;
            s1.Name = "Shyam";              //reference type
            s3.display();

            Console.WriteLine("No. of students: " + Student.count);

            Student s4 = new Student(s1);       //s1 is copied to s4
            s4.display();

        }

       
    }
}