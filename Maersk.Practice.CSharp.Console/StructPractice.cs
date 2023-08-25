using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    struct Address
    {
       public string City;
    }
    struct Name                     //value-type, No Inheritance
    {
        public String fName, lName;

        public Address address;     //nested struct

        public  Name(String val1, String val2)      //No parameterless constructors allowed
        {
            fName= val1;
            lName= val2;
        }

        public void display()
        {
            Console.WriteLine("First Name: " + fName + " " + " Last Name: " + lName);
        }

    }

    public class StructPractice
    {
        public static void Main(string[] args)
        {
            Name sp1 = new Name();                   //new not required
            sp1.fName = "Rahul";
            sp1.lName = "Roy";
            sp1.display();

            sp1.address.City = "Raipur";
            Console.WriteLine("Address: "+sp1.address.City);

            Name sp2 = new Name("Raj", "Anand");
            sp2.display();

            Name sp3 = new Name();
            sp3 = sp2;
            sp2.fName = "Raunak";           //value-type
            sp3.display();
        }
    }
    
}
