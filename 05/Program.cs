using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
             *  
             *  liner alghorithm
             *  I woke up      |
             *  I went to work |
             * 
             *  I woke up
             *  if today is a workday
             *  I went to work
             *  else i slept
             *  
             *  decision structure
             */

            //Console.WriteLine("Hello, I'm here");
            //Console.WriteLine("Writing some code");

            //int a = 5;
            //int b = 13;

            //Console.WriteLine(a * b);

            //keyword, a word that specifies something in the code

            /*
             *  if (condition) 
             *  {
             *    //code here
             *  }
             * 
             */

            //int a = 15;
            //int b = 14;

            //by default if will use one line after itself
            //if (b > a)
            //    Console.WriteLine("b is bigger than a");

            //if will use all lines between scope
            //if (b > a)
            //{
            //    Console.WriteLine("b is bigger than a");
            //    Console.WriteLine("hello there");
            //}

            //Console.WriteLine("Hello from out of if");

            //string transactionType = "Card";
            //string transactionType = Console.ReadLine();

            //if (transactionType == "Card")
            //{
            //    Console.WriteLine("Fetching amount from customers card...");
            //}


            //Option#1 Reading from console
            //string aText = Console.ReadLine();
            //string bText = Console.ReadLine();

            //int a = int.Parse(aText);
            //int b = int.Parse(bText);

            //Option#2 reading from console
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //bool c = "15" == 15;
            //"a" -> 67
            //"1" -> 101
            //"15" -> 101  106

            //int.Parse() converts text to number
            //string t = "15";
            //int i = int.Parse(t);

            //int x = 15;
            //Console.WriteLine(x);

            //if (a > b)
            //{
            //    Console.WriteLine("a > b");
            //}
            //else
            //{
            //    Console.WriteLine("b > a");
            //}

            //if (b > a)
            //{
            //    Console.WriteLine("b > a");
            //}

            //NOT WORKS, because we cannot convert text to text
            //string s = string.Parse("Hello");

            //string s1 = "Hello";
            //string s2 = s1;

            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("Number is divisible by two");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not divisible by two");
            //}

            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0 && a % 3 == 0)
            //{
            //    Console.WriteLine("Number is divisible by 6");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not divisible by 6");
            //}

            //Given a number, if number divisible by 2 print foo, 
            //if number divisible by 3 print bar
            //if number divisible by 6 print foobar

            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0 && a % 3 != 0)
            //{
            //    Console.WriteLine("foo");
            //}

            //if (a % 2 != 0 && a % 3 == 0)
            //{
            //    Console.WriteLine("bar");
            //}

            //if (a % 6 == 0)
            //{
            //    Console.WriteLine("foobar");
            //}

            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0 && a % 3 != 0)
            //{
            //    Console.WriteLine("foo");
            //}
            //else if (a % 2 != 0 && a % 3 == 0)
            //{
            //    Console.WriteLine("bar");
            //}
            //else if (a % 6 == 0)
            //{
            //    Console.WriteLine("foobar");
            //}
            //else
            //{
            //    Console.WriteLine("Nothing to write");
            //}

            //nested ifs, yuvalanmış iflər, iç içə iflər

            //int a = int.Parse(Console.ReadLine());

            //if (a % 6 == 0)
            //{
            //    Console.WriteLine("Divisible by 2 and 3");
            //}
            //else if (a % 2 == 0 && a % 3 != 0)
            //{
            //    Console.WriteLine("Divisible by 2 but not 3");
            //}
            //else if (a % 2 != 0 && a % 3 == 0)
            //{
            //    Console.WriteLine("Divisible by 3 but not 2");
            //}

            //int a = int.Parse(Console.ReadLine());

            ////nested ifs
            //if (a % 2 == 0)
            //{
            //    if (a % 3 == 0)
            //    {
            //        Console.WriteLine("Divisible by 2 and 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Divisible by 2 but not 3");
            //    }
            //}
            //else if(a % 3 == 0)
            //{
            //    if (a % 2 == 0)
            //    {
            //        Console.WriteLine("Divisible by 2 and 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Disible by 3 but not 2");
            //    }
            //}

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //a = b, a > b, b > a

            //if (a > b)
            //{
            //    Console.WriteLine("a > b");
            //}
            //else if ( b > a)
            //{
            //    Console.WriteLine("b > a");
            //}
            //else
            //{
            //    Console.WriteLine("b = a");
            //}

            //Homework#1
            // a,b,c -> a > b > c,
            // a > c > b,
            // b > a > c,
            // b > c > a,
            // c > b > a,
            // c > a > b

            //switch case

            //int a = int.Parse(Console.ReadLine());

            //switch (a) 
            //{
            //    case 0:
            //        Console.WriteLine("a is zero");
            //        break;
            //}


            //Homework#2, Write below code with Switch case and if else at home.
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("No valid operator given");
                    break;
            }
        }
    }
}
