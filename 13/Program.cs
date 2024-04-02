using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //insertion sort
            //12, 5, 7, 19, 0, 20, 1, 3, 9
            //5 12 7 19 0 20 1 3 9
            //5 7 12 19 0 20 1 3 9
            //5 7 12 0 19 20 1 3 9
            //5 7 0 12 19 20 1 3 9
            //0 5 7 12 19 20 1 3 9

            int[] arr = { 0, 5, 7, 12, 19, 20, 1, 3, 9 };

            //Print(arr);
            //InsertionSort(arr);
            //Print(arr);


            //O(1) - Heç bir dövr yoxdursa
            //O(n) - Bir dövrdən ibarətdirsə
            //O(n^2) - 2 ədəd iç içə dövrdən ibarətdirsə


            //Quick sort, Merge Sort
            //O(nlogn)
            //n = 100, 10 000
            //n = 100, 100 * 6 = 600


            //Counting sort
            //12, 5, 7, 19, 0, 20, 1, 3, 9
            //12: 1
            //5: 1 
            //7: 1 
            //19: 1
            //0: 1
            //20: 1
            //1: 1
            //3: 1 
            //9: 1

            //0 1 3 5 7 9 12 19 20

            //Print(arr);

            //CountingSort(arr);

            //quick sort
            //12, 5, 7, 19, 0, 20, 1, 3, 9
            //9
            //5, 7, 12, 19, 0, 20, 1, 3, 9
            //5, 7, 0, 19, 12, 20, 1, 3, 9
            //5, 7, 0, 1, 12, 20, 19, 3, 9
            //5, 7, 0, 1, 3, 20, 19, 12, 9
            //5, 7, 0, 1, 3, 9, 19, 12, 20
            //
            //array#1, 5, 7, 0, 1, 3,
            //array#2, 19, 12, 20
            //19 12 20
            //19 12 20
            //12 19 20


            //array#1
            //5 7 0 1 3
            //0 7 5 1 3
            //0 1 5 7 3
            //0 1 3 7 5
            //0 1 3 5 7 12 19 20

            //12, 5, 7, 19, 0, 20, 1, 3, 9
            //5 12 7 19 0 20 1 3 9
            //5 7 12 19 0 20 1 3 9

            //12 5 7 19 0 20 1 3 9
            //5 12 7 19 0 20 1 3 9
            //5 7 12 19 0 20 1 3 9
            //5 7 0 19 12 20 1 3 9
            //5 7 0 1 12 20 19 3 9
            //5 7 0 1 3 20 19 12 9
            //5 7 0 1 3 9 19 12 20
            //5 7 0 1 3 9 19 12 20
            //5 7 0 1 3 9 12 19 20
            //0 7 5 1 3 9 12 19 20
            //0 1 5 7 3 9 12 19 20
            //0 1 3 7 5 9 12 19 20
            //0 1 3 5 7 9 12 19 20


            //         t
            //   5 7 0 19 12 20 1 3 9
            //                  i
            //recursion
            //Hello();

            Print(arr);
            //Partition(arr, 0, arr.Length - 1);
            //Partition(arr, 0, 4);

            QuickSort(arr);
            Print(arr);
        }


        static void QuickSort(int[] arr)
        {
            int t = Partition(arr, 0, arr.Length - 1);

            Partition(arr, 0, t - 1);
            Partition(arr, t + 1, arr.Length - 1);
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

        static void Hello()
        {
            Console.WriteLine("Hello");

            Hello();
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }


        static void CountingSort(int[] arr)
        {
            int max = arr[0];

            //find max element in array
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            //create an array to store count infor in memory
            int[] mem = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                int val = arr[i];
                mem[val] += 1;
            }


            for (int val = 0; val < mem.Length; val++)
            {
                int count = mem[val];

                for (int i = 0; i < count; i++)
                {
                    Console.Write(val + " ");
                }
            }

            Console.WriteLine();
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
