using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 10;
            //for (int i = 1; i < n; i++)
            //{
            //    for (int j = 1; j < n; j++)
            //    {
            //        //Console.Write(i  + " * " + j + " = "  + (i * j) + "\t");
            //        //Console.Write($"{i} * {j} = {i * j}\t");
            //    }

            //    Console.WriteLine();
            //}

            //data structure
            //arrays
            //string[] s = new string[5];

            //c# syntax
            //int[] a = new int[4];
            //a[0] = 1;
            //a[1] = 2;
            //a[2] = 3;
            //a[3] = 4;

            //int[] b = new int[4] { 1, 2, 3, 4 };

            //int[] c = { 1, 2, 3, 4 };


            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i + 1;
            //}

            //int[] arr2 = new int[n];
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = arr[i];
            //}

            //int[] arr2 = arr;
            //arr2[9] = 100;

            //Console.WriteLine("array 1:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine("\narray 2:");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}

            //int a = 50;
            //int b = a;
            //b = 40;
            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //Console.WriteLine();
            //Console.WriteLine("showing numbers from 1 to 20");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.Write((i + 1) + " ");
            //}

            ////Console.WriteLine();

            ////Console.ReadKey();

            //Reverse the given array
            //option#1
            //int[] arr = { 1, 2, 3, 4, 5 };

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = new int[arr1.Length];

            ////Console.WriteLine(arr1[arr1.Length - 1]);

            //////
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = arr1[arr1.Length - 1 - i];
            //}

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}

            //int[] arr1 = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = arr1[arr1.Length - 1 - i];
            //}

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write(arr1[i] + " ");
            //}

            //Homework#1 do in place reverse for the array

            // multi dimensional array
            //çox ölçülü massivlər
            /*
             *   1 2 3 4 5
             *   1 2 3 4 5
             *   1 2 3 4 5
             */

            int[,] arr = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] =  i + j;
                }
            }

            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr.GetLength(0));
            //Console.WriteLine(arr.GetLength(1));

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }


            //for (int i = 0; i < ; i++)
            //{
            //    for (int i = 0; i < length; i++)
            //    {

            //    }
            //}

            //Homework#2, Find maximum value at given array
            //Find minimum value at given array

            //Print below array at screen
            /*
             * 1 0 0
             * 2 4 0 
             * 3 5 6
             */

            /*
             * Homework 
             * 
             * Sum of Array Elements:
             * Write a function that takes an array of integers as input and returns the sum of all elements in the array.
             * Find Maximum Element:
             * Write a function that takes an array of integers as input and returns the maximum element in the array.
             * 
             * Calculate Average:
             * Write a function that takes an array of numbers as input and returns the average of all elements.
             * 
             * Transpose 2D Array:
             * Write a function that takes a 2D array (list of lists) as input and returns its transpose.
             */
        }
    }
}
