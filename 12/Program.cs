using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort, search

            //selection sort
            //5 2 3 1 4
            //1 2 3 5 4
            //1 2 3 4 5
            //
            //1 2 3 4 5

            //Bubble sort
            //5 2 3 1 4
            //0 1 2 3 4
            //0,1 1,2 2,3 3,4 comparisons
            //2 5 3 1 4
            //2 3 5 1 4
            //2 3 1 5 4
            //2 3 1 4 5
            //
            //2 3 1 4 5
            //2 1 3 4 5
            //1 2 3 4 5
            //5 2 3 1 4
            //5 2 3 1 4

            //12 5 7 19 0 20 1 3 9
            //5 12 7 19 0 20 1 3 9
            //5 7 12 19 0 20 1 3 9
            //5 7 12 0 19 20 1 3 9
            //5 7 12 0 19 1 20 3 9
            //5 7 12 0 19 1 3 20 9
            //5 7 12 0 19 1 3 9 20
            //5 7 0 12 19 1 3 9 20
            //5 7 0 12 1 19 3 9 20
            //5 7 0 12 1 3 9 19 20
            //5 0 7 1 3 9 12 19 20
            //0 1 3 5 7 9 12 19 20

            int[] arr = { 12, 5, 7, 19, 0, 20, 1, 3, 9 };

            //PrintArr(arr);

            //BubbleSort(arr);

            //PrintArr(arr);


            //Selection sort

            //12 5 7 19 0 20 1 3 9
            //0 5 7 19 12 20 1 3 9
            //0 1 7 19 12 20 5 3 9
            //0 1 3 19 12 20 5 7 9
            //

            //PrintArr(arr);

            //SelectionSort(arr);

            //PrintArr(arr);

            //Insertion sort
            //Steven Skiena, The Alghrotihm design manual


            //12, 5, 7, 19, 0, 20, 1, 3, 9

            //5, 12, 7, 19, 0,  20, 1,  3, 9
            //5, 7, 12, 19, 0,  20, 1,  3, 9
            //0, 5, 7,  12, 19, 20, 1,  3, 9
            //0, 1, 5,  7,  12, 19, 20, 3, 9
            //0, 1, 3,  5,  7,  12, 19, 20,9

            //Worst case: O(n^2)
            //Best case: O(n)

            //PrintArr(arr);

            //InsertionSort(arr);

            //PrintArr(arr);

            //Homework, write all below sorts 
            //Optimize the sort alghorithms, like if array already sorted, don't do extra iterations
            //BubbleSort
            //SelectionSort
            //InsertionSort


            //ctrl + z
            //ctrl + y            
            //ctrl + k, c
            //ctrl + k, u
            //ctrl + d, duplicate line

            Console.WriteLine();
            Console.WriteLine();
        }

        static void BubbleSort(int[] arr)
        {
            //Big O for speed: O(n^2)
            //Big O for memory: O(1)
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        //arr[j - 1] is coke
                        //arr[j] is ayran
                        //temp is boş qab

                        //boş qabın içinə ayran qoyuram
                        int temp = arr[j];

                        //ayran qabının içinə kola qoyuram
                        arr[j] = arr[j - 1];

                        //ayranı qaytarıram kolan qabının içinə
                        arr[j - 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void PrintArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
