using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //# strings
            //string s = "test";

            //methods - functions

            //string a = "test";

            //Console.WriteLine(a);

            //string s = "This is new string";
            //s = s.Replace("new", "old");

            //Console.WriteLine(s);

            //string s = "Price: $$";
            //s = s.Replace("$$", "$50");

            //Console.WriteLine(s);

            //string[] firstnames = { "Mahammad", "Cavid" }; 
            //string[] lastnames = { "Agayev", "Aliyev" }; 

            //for (int i = 0; i < firstnames.Length; i++)
            //{
            //    Console.WriteLine(firstnames[i].PadLeft(10, '=') + " " + lastnames[i]);
            //}

            //string text = "This is sample text";

            //string[] words = text.Split(' ');

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //Console.WriteLine(words.Length);

            //string a = "test";


            //#Methods 
            //code reuse

            //int[] arr = { 4, 3, 5, 15, 20, -6 };
            //int max = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}

            //Console.WriteLine(max);

            //int[] arr2 = { 100, 10, 2000, 100001, 5151, 12345 };

            //int max2 = arr2[0];

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    if (max2 < arr2[i])
            //    {
            //        max2 = arr2[i];
            //    }
            //}

            //Console.WriteLine(max2);

            //call the method, metodu çağırmaq

            //string a = "Mahammad";
            //SayHello(a);
            //SayHello("Mahammad");
            //SayHello("Cavid");

            //string n = Console.ReadLine();
            //SayHello(n);

            //SayHello2("Hi", "Mahammad");

            //Sum(1, 2);

            //PrintPoints("A", 25);
            //PrintPoints("B", 18);
            //PrintPoints("C", 15);
            //copy, cut, paste
            //ctrl + z, go bac\k
            //ctrl + d, duplicate

            //int[] arr = { 2, 1, 6, 10, -4, 16 };
            //FindMax(arr);

            //int[] arr2 = { -100, 1000, 78923, 15, 67891 };
            //FindMax(arr2);

            //int a = Sum(1, 2);
            //int b = Sum(2, 3);

            //int c = Sum(a, b);

            //int c1 = Sum(Sum(1, 2), Sum(2, 3)); 

            //Console.WriteLine(c);

            //string card = null;

            //bool isValid = IsValidCardNumber(card);

            //Console.WriteLine(isValid);

            //syntactic sugar
            //method overloading

            //method overloading
            //int sum = Sum(1, 2);
            //int sum2 = Sum(1, 2, 3);
            //int sum3 = Sum(1, 2, 3, 4);


            //int sum = Sum(1, 2);
            //int sum1 = Sum(1, 2, 3);
            //int sum = Sum();

            //Console.WriteLine(sum);

            //int[] arr = { 4, 6, 10, 3, 9, 1 };

            //int sum = SumArr(arr);

            //int sum = SumArr(4, 6, 10, 3, 9, 1);

            //Console.WriteLine(sum);

            /*
             * Homework 
             * - Write a method that reverses the number and returns the result
             * - Write a method that find factorial of given number, 5! = 1 * 2 * 3 * 4 * 5
             *     //input:  5
             *     //output: 120
             * 
             * - Write a method to find the nth fibonacci number
             *    //sample fibonacci numbers: 0,1,1,2,3,5,8,13
             *    //input:  3, 7 
             *    //output: 1, 8
             * 
             * - Write a method to find word with max letters in given sentence:
             *   //input: This is a interesting lesson.
             *   //output: interesting
             */
        }
        
        //static return-type method-name, (type name)
        static void SayHello(string name)
        {
            Console.WriteLine("" + name);
        }

        static void SayHello2(string prefix, string name)
        {
            Console.WriteLine(prefix + " " + name + "!");
        }

        static int SumArr(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        //static int Sum(int a, int b, int c = 0)
        //{
        //    int sum = a + b + c;

        //    return sum;
        //}

        //static int Sum(int a, int b, int c)
        //{
        //    int sum = a + b + c;

        //    return sum;
        //}

        //static int Sum(int a, int b, int c, int d)
        //{
        //    int sum = a + b + c + d;

        //    return sum;
        //}

        //static return-type method-name parameters, 
        static void PrintPoints(string user, int points)
        {
            Console.WriteLine($"User {user} has scored {points} points");
        }

        static void FindMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }

        static bool IsValidCardNumber(string cardNumber)
        {
            //if (cardNumber.Length == 16)
            //{
            //    return true;
            //}

            if (string.IsNullOrEmpty(cardNumber))
            {
                return false;
            }

            if (cardNumber.Length != 16)
            {
                return false;
            }

            return true;
        }
    }
}
