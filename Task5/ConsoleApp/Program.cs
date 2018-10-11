using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 7, 9, 5, 6, 2, 8, 3, 4, 0 };
            Sorts s = new Sorts();

            Console.Write("Before:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();

            arr = s.MergeSort(arr);

            Console.Write("After:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

            Console.ReadKey();

        }
    }
}
