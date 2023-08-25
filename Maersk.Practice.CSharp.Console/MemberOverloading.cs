using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class MemberOverloading
    {
        public class DifferentDatatype
        {
            public int Add(int a, int b, int c)
            {
                int sum = a + b + c;
                return sum;
            }

            public double Add(double a, double b, double c)
            {
                double sum = a + b + c;
                return sum;
            }

            public static void Main(String[] args)
            {
                DifferentDatatype obj = new DifferentDatatype();

                int sum2 = obj.Add(32, 245, 7);
                Console.WriteLine("sum of the integers = " + sum2);

                double sum3 = obj.Add(235.675, 35.78, 24.76);
                Console.WriteLine("sum of the doubles = "+ sum3);
            }
        }

        public class DifferentNoOfArguments
        {
            public int Add(int a, int b)
            {
                int sum = a + b;
                return sum;
            }

            public int Add(int a, int b, int c)
            {
                int sum = a + b + c;
                return sum;
            }

            public static void Main(String[] args)
            {
                DifferentNoOfArguments ob = new DifferentNoOfArguments();

                int sum1 = ob.Add(35,56);
                Console.WriteLine("sum of the two integrs = " + sum1);

                int sum2 = ob.Add(245,75,325);
                Console.WriteLine("sum of the three integers = " + sum2);
            }
        }

        public class DifferentOrderOfArguments
        {
            public void Introduction(String name, int id)
            {

                Console.WriteLine("Name1 : " + name + ", " + "Id1 : " + id);
            }

            public void Introduction(int id, String name)
            {

                Console.WriteLine("Name2 : " + name + ", " + "Id2 : " + id);
            }

            public static void Main(String[] args)
            {
                DifferentOrderOfArguments obj = new DifferentOrderOfArguments();

                obj.Introduction("Sandhya", 24);

                obj.Introduction(8, "Harsh");
            }
        }

    }
        
}
