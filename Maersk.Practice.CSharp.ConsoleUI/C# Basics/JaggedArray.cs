using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{
    internal class JaggedArray
    {
        public static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
            Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3, 4, 5};
            arr[1] = new int[] { 23, 35, 657, 23, 67, 879, 32 };
            arr[2] = new int[] { 54, 76, 25, 677, 3256, 55, 5, 53 };

            PrintArray(arr);
        }
    }
}
