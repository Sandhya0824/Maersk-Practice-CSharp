using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    class AboveThreshold : Exception            //User Defined Exception
    {
        public AboveThreshold() 
        {
            Console.WriteLine("Warning......!!!");
        }

    }
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            ExceptionHandling e=new ExceptionHandling();
            //e.CheckThreshold(25);
            //e.CheckThreshold(60);   

            checked
            {
                int n1 = int.MaxValue;
                //Console.WriteLine(n1+2);    //explicitly checks at compile time
            }

            unchecked
            {
                int n1 = int.MaxValue;
                Console.WriteLine(n1 + 2);    //explicitly does not checks and produces wrong results
            }
        }

        public void CheckThreshold(int value)
        {
            if (value > 50)
            {
                throw new AboveThreshold();
            }
            else
            {
                Console.WriteLine("You are good to go!");
            }
        }

        public static void ExceptionHandlingBasics()
        {
            int[] a = { 1, 2, 3, 0, 5, 6, 7, 8 };

            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i] / a[i + 1]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
}
