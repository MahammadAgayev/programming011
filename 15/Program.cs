using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bubble, Selection, Insertion, 
            //Counting Sort
            //QuickSort, Merge sort

            //search algos
            //linear 
            //binary

            //int[] arr = {5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            ////index of 10
            //int index = LinearSearch(arr, 10);

            //Console.WriteLine(index);
            //Big O for linear search
            //O(n) speed
            //O(1) memory

            //5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 
            //5, 6, 7, 8, 9, 10
            //5, 6, 7
            //5
            //Big O, 
            //O(logn)

            //Console.WriteLine(long.MaxValue);

            //int[] arr = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            //int idx = BinarySearch(arr, 10);
            //Console.WriteLine(idx);

            //int[] arr = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            ////int idx = BinarySearch(arr, 16);
            //int idx = BinarySearchRecurse(arr, 16, 0, arr.Length);
            //Console.WriteLine(idx);

            //Algorithms 

            //Obyektyönümlü proqramlaşdırma
            //OOP -> object oriented programming
            //Assembly, functional, OOP
            //class and object

            //Abstraction

            //Encapsulation
            //Inheritence - Miras - Code Reuse
            //Polymorphism


            // Enemy:
                //Die()
                //BossEnemy : Enemy
            
            
        }

        static int BinarySearchRecurse(int[] arr, int searchElement, int start, int end)
        {
            if (start > end )
            {
                return -1;
            }

            int mid = start + ((end - start) / 2);

            if (arr[mid] == searchElement)
            {
                return mid;
            }

            if (arr[mid] < searchElement)
            {
                return BinarySearchRecurse(arr, searchElement, mid + 1, end);
            }
            else
            {
                return BinarySearchRecurse(arr, searchElement, start, mid);
            }
        }

        static int BinarySearch(int[] arr, int searchElement)
        {
            int start = 0;
            int end = arr.Length;

            while (start < end)
            {
                int mid = start + ((end - start) / 2);

                if (arr[mid] == searchElement)
                {
                    return mid;
                }

                if (searchElement > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }

            return -1;
        }

        static int LinearSearch(int[] arr, int searchElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchElement)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
