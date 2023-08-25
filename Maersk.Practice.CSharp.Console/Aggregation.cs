using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    public class DetailedAddress                    //defining the class as an Entity
    {
        public int flatNo;
        public string building;
        public string landmark;

        public DetailedAddress(int flatNo, string building, string landmark)
        {
            this.flatNo = flatNo;
            this.building = building;
            this.landmark = landmark;
        }
    }

    public class StudentDetails                     //Referenced by this class HAS-A Relationship
    {
        public int studentId;
        public string name;
        public DetailedAddress detailedAddress;

        public StudentDetails(int studentId, string name, DetailedAddress detailedAddress)
        {
            this.studentId = studentId;
            this.name = name;
            this.detailedAddress = detailedAddress;
        }

        public void displayDetails()
        {
            Console.WriteLine("Student ID: "+studentId+" Name: "+name+" Address: "+detailedAddress.flatNo
                +" , "+detailedAddress.building+" , "+detailedAddress.landmark);
        }
    }
    internal class Aggregation
    {
        public static void Main(string[] args)
        {
            DetailedAddress detailedAddress = new DetailedAddress(23, "Yolo", "KNS College");
            StudentDetails studentDetails = new StudentDetails(0001, "Ram", detailedAddress);
            studentDetails.displayDetails();
        }
    }
}
