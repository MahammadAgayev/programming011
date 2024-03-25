using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 6;

            //int temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //Write a method to reverse the given array
            //input: [1 2 3 4]
            //output: [4 3 2 1]


            //Homework#3
            // #1 Divide sentence by .Split()
            // #2 Check length of each text
            string text = "hello there";
            Console.WriteLine(text.Length);


            //Alghorithms
            //Alghoritms, Analysis of algorithms
            //Sorting, Searching
            //Text, Blocks(Figures), pesuedocode or code
            //Wake up, go work/go lesson - linear, text
            //Wake up, if weather is ok, go work - conditional, text
            //Everyday, if not died, wake up, go work - loop, text
            //789348 -> 7 + 8 + 9 + 3 + 4 + 8
            //
            /*
             *  a = userinput
             *  b = userinput
             *  
             *  if a > b {
                  print(a b-den boyukdur)
             *  }
             */


            /* Write below alghorithm as peseudcode
              if user password is correct
              if card is not expired
              if card is not blocked 
              request amount from user
              if userbalance <= amount
              if amount <= cash in ATM
              give cash to user
             */


            /*
            power received
            boot, check hardware, RAM, CPU, Hard disk/SSD
            if all hardware systems is ok
            load operating system from hard drive
            open operating system
             */

            //Analysis of Algorithm
            //Checks resources required for doing the algorithm

            //Big O Notation
            // input: 10 -> 1s, input: 100 -> 10s, linear growth = O(n)
            // input: 10 -> 1s, input: 100 -> 1s, constant = O(1)
            // inpput: 10 -> 1s, input: 100 -> 100s, exponential growth = O(n^2)

            //O(1) - constant duration
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine(a % 10);

            //sum of number for 1 to n
            //O(n) = linear growth
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);


            //O(n^2) exponential growth

            //int n = int.Parse(Console.ReadLine());
            //long sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j= 0; j < n; j++)
            //    {
            //        sum += i + j;
            //    }
            //}

            //Console.WriteLine(sum);


            //Compute, Store,
            //Memory Big O: O(1)
            //int n = int.Parse(Console.ReadLine());

            //int b = n;
            //Console.WriteLine(b);


            //O(n)
            //int a = int.Parse(Console.ReadLine());

            //int[] arr = new int[a];



            //O(n^2) memory

            int n = int.Parse(Console.ReadLine());

            int[,] arr = new int[n, n];

            Console.WriteLine(arr.Length);

            //Big O notation, constantlar silinir
            //O(n) = O(2n) , O(n) = O(200n)
            //Analysis of Algorithm

            //Sorting algorithms
            //
        }
    }
}
