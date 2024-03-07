using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //solution#1
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //solution#2
            //for (int i = 0; i < 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 100; i >= 50; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //output
            /*
             * 100 
             * 99
             * 98
             * 
             * 100 99 98 97 ....
             * 90  89 88 87 ....
             * 80  79 78 77
             * 
             */

            //Talk is cheap, show me the code

            //for (int i = 100; i >= 60; i -= 10)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        //j = 1, j = 2, j = 3

            //        Console.Write(i - j + " ");
            //    }
            //    Console.WriteLine();
            //}

            //with 1 for
            //for (int i = 100; i >= 50; i--)
            //{
            //    if(i != 100 && i % 10 == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //    Console.Write(i + " ");
            //}

            //for(;true;)
            //{
            //    Console.WriteLine("Hellooooooooo");
            //}

            //int i = 0;
            //for(; i< 1000;)
            //{
            //    Console.WriteLine(i);

            //    i++;
            //}

            //while (false)
            //{
            //    Console.WriteLine("hellooo");
            //}

            //Find the count of digits in number
            //int a = 12133213;
            //int count = 0;

            //while (a != 0)
            //{
            //    a /= 10;

            //    count++;
            //}
            //Console.WriteLine(count);

            //int a = 124352;
            //int count = (int)Math.Log10(a) + 1;

            //Console.WriteLine(count);

            //while (false)
            //{
            //    Console.WriteLine("Helloooo");
            //}

            //do
            //{
            //    Console.WriteLine("Helloo");
            //} while (true);

            //Stars

            /*
             * 0 1 2 3 4 5 6 7 8 9
             * 1 *        
             * 2 * * 
             * 3 * * * 
             * 4 * * * * 
             * 5 * * * * * 
             * 6 * * * * * *
             * 7 * * * * * * * 
             * 8 * * * * * * * * 
             * 9 * * * * * * * * * 
             */

            //sətr -> i
            //sütün -> j

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (i <= j)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }

            //    Console.WriteLine();
            //}

            //Homework#1 Print the right down triangle with star, See below:
            /*
             * 0 1 2 3 4 5 6 7 8 9
             * 1                 *
             * 2               * *
             * 3             * * *
             * 4           * * * *
             * 5         * * * * * 
             * 6       * * * * * *
             * 7     * * * * * * *
             * 8   * * * * * * * *
             * 9 * * * * * * * * * 
             */

            //Find the sum of the digits of given number

            /*
             *  145 => 3
             *  
             *  145 % 10 = 5
             *  145 / 10 = 14
             *  
             *  14 % 10 = 4
             *  14 / 10 = 1
             *  
             *  1 % 10 = 1
             */

            //int a = 145;
            //int sum = 0;
            //while (a != 0)
            //{
            //    int n = a % 10;
            //    sum += n;

            //    a /= 10;
            //}
            //Console.WriteLine(sum);

            //Homework#2: Find the product of the digits of the give number
            //Homework#3: Print the product table(vurma cədvəli) using the nested fors
            //Homework#4: Palindrome numbers, If number is palindrome print true, if it isn't print false
            //Palindrome numbers: 123321, 101, 3443, 6776. 9009, 99, 77, 76567

            //Find the first digit of given number

            //1234
            //int a = int.Parse(Console.ReadLine());
            //int len = (int)Math.Log10(a); //3

            //int root = (int)Math.Pow(10, len);//1000

            //Console.WriteLine(a / root);

            //array, massiv, çoxluq
            //data structure, 
            //int a1 = 20;
            //int a2 = 30;
            //int a3 = 35;

            //int[] a = new int[5];
            //a[0] = 12;
            //a[1] = 15;
            //a[2] = 9;
            //a[3] = 21;
            //a[4] = 46;

            /*
             *  +-----+   +-----+  +-----+  +-----+  +-----+
             *  |  12 |   |  15 |  | 9   |  |  21 |  | 46  |
             *  +-----+   +-----+  +-----+  +-----+  +-----+
             *    0          1        2        3        4
             */

            //for (int i = 0; i < a.Length; i++)
            //{
            //    //a[i] = i + 1;
            //    Console.Write("a[" + (i + 1) + "]: ");
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}

            //Console.WriteLine();

            //Console.Write("Element count: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("a[" + (i + 1) + "]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Data written to array.");

            //Console.WriteLine("Printing data from array...");

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Read about arrays, Massivlər
        }
    }
}
