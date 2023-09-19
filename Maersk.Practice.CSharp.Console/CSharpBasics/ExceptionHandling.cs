using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.CSharp.ConsoleUI.CSharpBasics
{
    class AboveThreshold : Exception            //User Defined Exception
    {
        public AboveThreshold()
        {
            System.Console.WriteLine("Warning......!!!");
            System.Console.WriteLine();
        }

    }
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            ExceptionHandling e = new ExceptionHandling();
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
                System.Console.WriteLine(n1 + 2);    //explicitly does not checks and produces wrong results
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
                System.Console.WriteLine("You are good to go!");
            }
        }

        public static void ExceptionHandlingBasics()
        {
            int[] a = { 1, 2, 3, 0, 5, 6, 7, 8 };

            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    System.Console.WriteLine(a[i] / a[i + 1]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                System.Console.WriteLine(e.ToString());
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.ToString());
            }
            finally
            {
                for (int i = 0; i < a.Length; i++)
                {
                    System.Console.WriteLine(a[i]);
                }
            }
        }
    }
}
