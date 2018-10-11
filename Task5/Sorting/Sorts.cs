using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// The Sorts class has methods for sorting
    /// </summary>
    public class Sorts
    {
        #region QuickSort
        /// <summary>
        /// Quick sort
        /// </summary>
        /// <param name="arr">Array</param>
        /// <param name="first">Number of first element</param>
        /// <param name="last">Number of last element</param>
        public void QuickSort(int[] arr, int first, int last)
        {
            int temp;
            int marker = arr[first + (last - first) / 2];
            int i = first;
            int j = last;

            while(i <= j)
            {
                while(arr[i] < marker)
                {
                    i++;
                }
                while(arr[j] > marker)
                {
                    j--;
                }

                if(i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }
            }

            if(i < last)
            {
                QuickSort(arr, i, last);
            }
            if(first < j)
            {
                QuickSort(arr, first, j);
            }
        }
        #endregion

        #region MergeSort
        /// <summary>
        /// Merge sort
        /// </summary>
        /// <param name="arr">Input array</param>
        /// <returns>Sorted Array</returns>
        public int[] MergeSort(int[] arr)
        {
            int marker;

            if(arr.Length == 1)
            {
                return arr;
            }

            marker = arr.Length / 2;

            return Merge(MergeSort(arr.Take(marker).ToArray()), MergeSort(arr.Skip(marker).ToArray()));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr1">First array</param>
        /// <param name="arr2">Second array</param>
        /// <returns>Sorted array</returns>
        private int[] Merge(int[] arr1, int[] arr2)
        {
            int temp1 = 0;
            int temp2 = 0;

            int size = arr1.Length + arr2.Length;
            int[] merged = new int[size];

            for(int i = 0; i < size; i++)
            {
                if(temp1 < arr1.Length && temp2 < arr2.Length)
                {
                    if(arr1[temp1] > arr2[temp2])
                    {
                        merged[i] = arr2[temp2++];
                    }
                    else
                    {
                        merged[i] = arr1[temp1++];
                    }
                }
                else if(temp2 < arr2.Length)
                {
                    merged[i] = arr2[temp2++];
                }
                else
                {
                    merged[i] = arr1[temp1++];
                }
            }
            return merged;
        }
        #endregion
    }
}
