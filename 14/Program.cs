using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //recursion
            //

            //f(x)
            //f(10) = f(9) + 10
            //f(9) = f(8) + 9
            //f(8) = f(7) + 9
            //f(7) = f(6) + 7
            //f(0) = 0

            //Print(0);

            //Console.WriteLine(Sum(10));

            //Homework: write fibonacci with recursion

            //7 1 9 11 10 4 19 5 8 3
            //1 7 9 11 10 4 19 5 8 3
            //1 3 9 11 10 4 19 5 8 7

            //Divie and Conquer
            //QuickSort() recursive
            //QuickSort(arr, left, right)

            /* 
             *   QuickSort()
             *    
             *      t = Partition()
             *      
             *      QuickSort part of the array that is below t
             *      QuickSort part of the array that is above t
             * 
             *  
             */

            int[] arr = { 10, 7, 8, 9, 1, 5, 19, 3, 2, 11, 6, 4, 18, 14, 16, 15, 12, 17, 13 };

            //Print(arr);

            //QuickSort(arr, 0, arr.Length - 1);

            //Print(arr);


            //Merge sort
            //7 1 9 11 10 4 19 5 8 3
            /* 
             *  7 1 9 11 10           4 19 5 8 3
             *      
             *   7 1 9  11 10         4 19 5     8 3
             *                       4 19  5    8   3
             *   7 1    9          4   19        3 8
             *                    4 19 
             *   7 1          4 5 19     
             *                  
             *   1 7 9 10 11           3 4 58 19
             *   
             *   O(n) 1 3 4 5 7 8 9 10 11
             *   
             *   4 5 19  3 8
             *       |       |
             *   
             *   3 4 5 8 19
             **/


            //
            /*
             *   5 6 8     1 7 10
             *   
             *   {            }
             * 
             */
            //int[] arr1 = { 5, 6, 8 };
            //int[] arr2 = { 1, 7, 10 };

            //int[] res = MergeArray(arr1, arr2);

            //Print(res);

            int[] arr1 = { 7, 1, 9, 11, 10, 4, 19, 5, 8, 3 };

            Print(arr1);

            int[] sorted = MergeSort(arr1);

            Print(sorted);

        }


        static int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int mid = arr.Length / 2;

            if (arr.Length % 2 != 0)
            {
                mid += 1;
            }

            int[] arr1 = new int[mid];
            int[] arr2 = new int[arr.Length - mid];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }

            for (int i = 0; i< arr2.Length ; i++)
            {
                arr2[i] = arr[mid + i];
            }

            int[] sorted1 = MergeSort(arr1);
            int[] sorted2 = MergeSort(arr2);

            int[] sorted = MergeArray(sorted1, sorted2);

            Print(sorted);

            return sorted;
        }

        static int[] MergeArray(int[] a1, int[] a2)
        {
            int[] res = new int[a1.Length + a2.Length];

            int p1 = 0;
            int p2 = 0;
            int pRes = 0;

            while(pRes < res.Length)
            {
                //this condition takes only from box 2 because box 1 is empty
                if (p1 == a1.Length)
                {
                    res[pRes] = a2[p2];
                    pRes++;
                    p2++;

                    continue;
                }

                //this condition takes only from box 1 because box 2 is empty
                if (p2 == a2.Length)
                {
                    res[pRes] = a1[p1];
                    pRes++;
                    p1++;

                    continue;
                }

                //take data from smaller one
                if (a1[p1] < a2[p2])
                {
                    res[pRes] = a1[p1];
                    pRes++;
                    p1++;
                }
                else
                {
                    res[pRes] = a2[p2];
                    pRes++;
                    p2++;
                }
            }

            return res;
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int t = Partition(arr, left, right);

            QuickSort(arr, left, t - 1);
            QuickSort(arr, t + 1, right);
        }


        static int Partition(int[] arr, int left, int right)
        {
            int rand = arr[right];

            int t = left - 1;

            for (int i = left; i <= right; i++)
            {
                if (arr[i] < rand)
                {
                    t++;

                    int temp2 = arr[i];
                    arr[i] = arr[t];
                    arr[t] = temp2;

                }
            }

            t++;

            int temp = arr[right];
            arr[right] = arr[t];
            arr[t] = temp;

            return t;
        }

        static int Sum(int x)
        {
            //base case
            if (x == 0)
            {
                return 0;
            }

            //recursion
            return x + Sum(x - 1);
        }

        static void PrintRecurse(int i)
        {
            if (i == 10)
            {
                return;
            }

            Console.WriteLine(i);

            PrintRecurse(i + 1);
        }


        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
