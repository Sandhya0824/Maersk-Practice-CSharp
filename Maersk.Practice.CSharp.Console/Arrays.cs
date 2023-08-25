using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpLearning
{
    internal class Arrays
    {

        public static void Main(String[] args)
        {
            int[][] a = new int[3][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 9, 10 },
                new int[] { 7 }
            };

            //   printArray(a);      //printitng jagged array

            int[,] b = new int[3,4];

            Console.WriteLine(b.Length);
            Console.WriteLine(b.Rank);

            printArray();
        }

        public static void printArray(params int[][] array)     //params
        {
            for(int i=0;i<array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }
        }

        public static void arrDeclaration(int[] a)
        {
            int[] a1 = new int[3];
            int[,] a2 = new int[3, 4];
            int[][] a3 = new int[3][];

            int[][] a4 = new int[3][]
            {
                new int[] {2,3,4},
                new int[] {2,3,4,5},
                new int[] {2,3,4,6},
            };


        }
    }
}
