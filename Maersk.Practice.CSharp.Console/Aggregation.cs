using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics
{
    public class Address
    {
        public string addressLine, city, state;
        public Address(string addressLine, string city, string state)
        {
            this.addressLine = addressLine;
            this.city = city;
            this.state = state;
        }
    }
    public class NewStudent
    {
        public int id;
        public string name;
        public Address address;
        public NewStudent(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " +
            address.addressLine + " " + address.city + " " + address.state);
        }
    }
    public class Aggregation
    {
        public static void Main(string[] args)
        {
            Address a = new Address("K.P Lane Kabir Bagh", "Gaya", "Bihar");
            NewStudent s = new NewStudent(1, "Aakriti", a);
            s.display();
        }
    }
}

