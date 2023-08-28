using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Basics
{
    // Arrayis a group of similar types of elements that have contiguous memory location.
    //In C#, array is an object of base type System.Array. 
    //Array index starts from 0
    public class Arrays { 
        public static void MinNMaxArray(int[] arr1)
        {
            int min = arr1[0];
            int max = arr1[0];
            for (int i = 1; i < arr1.Length; i++) {
                if (min > arr1[i])
                {
                    min = arr1[i];
                }
                if(max < arr1[i]) 
                { 
                    max = arr1[i];
                }
            }
            Console.WriteLine("Min element in arr1: "+min);
            Console.WriteLine("Max element in arr1: " + max);

        }

        public static void Main(string[] args)
        {
            //Single Dimensional Array
            int[] arr = new int[5];//creating array
            arr[0] = 10;//initializing array
            arr[1] = 20;
            arr[2] = 30;
            for (int i = 0; i< arr.Length; i++)//traversing array
            {
                Console.WriteLine(arr[i]);
            }
            //Declaration and initialization at the same time
            int[] arr1 = new int[5] {1,2,3,4,5};//1st Way
            int[] arr2= new int[] {1,2,3,4,5};//2nd way
            int[] arr3 = {1,2,3,4,5};
            //Traversal using foreach loop
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            //Passing Array to Function : EX - Print minimum and maximum element in a array.
            MinNMaxArray(arr1);

            //Multidimensionaql Array
            int[,] arr4 = new int[3, 3];
            arr4[0, 1] = 100;//initialization  
            arr4[1, 2] = 200;
            arr4[2, 0] = 300;
            Console.WriteLine("Multidimensional array");
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr4[i,j]+" ");
                }
                Console.WriteLine();
            }
            //Declaration and initialization at same time
            int[,] arr5 = new int[3, 3] { { 101,102,103},
                                           { 104,105,106},
                                           { 107,108,109} 
            };
            //Jagged Array Example
            Console.WriteLine("Jagged Array");
            int[][] arr6 = new int[2][] ;
            arr6[0] = new int[] { 14, 04, 2002 };
            arr6[1] = new int[] { 14, 04, 2002, 18, 03, 2001 };
            for (int i = 0; i < arr6.Length; i++)
            {
                for(int j=0;j < arr6[i].Length; j++)
                {
                    Console.Write(arr6[i][j]+" ");  
                }
                Console.WriteLine() ;
            }


        }
    }
}
