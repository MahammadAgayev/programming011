using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //linear
            //decision structures(budaqlanan)
            //loops(dövrlər)

            //for
            //int a  = int.Parse(Console.ReadLine());
            //Console.WriteLine(a % 10);

            //19021 / 10 =  1902 qaliq = 1
            //19021 / 100 = 190  qaliq 21
            //19021 % 100 = 21

            //19021
            //1
            //2

            //#1
            //Solution#1
            //19021 % 10 = 1
            //19021 % 100 = 21 / 10 = 2 

            //Solution#2
            //19021 % 10 = 1
            //19021 / 10 = 1902 % 10 = 2

            //int a = int.Parse(Console.ReadLine());

            //int b = a % 10;
            //int c = a % 100 / 10;

            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //verilmiş 6 rəqəmli ədədin rəqəmləri cəmini tapın.
            //int a = int.Parse(Console.ReadLine());

            //input:  678902
            //output: 32

            //#2
            //int a = int.Parse(Console.ReadLine());

            //Console.OutputEncoding = Encoding.UTF8;
            //if (a % 6 == 0)
            //{
            //    Console.WriteLine("Verilmiş ədəd 6-ya bölünür");
            //}

            //#3
            //int a = int.Parse(Console.ReadLine());
            //int a1 = int.Parse(Console.ReadLine());
            //int a2 = int.Parse(Console.ReadLine());

            //Console.WriteLine(a + a1 + a2);

            //input:  12 3 5
            //output: 20

            //int[] vals = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //int a = vals[0];
            //int a1 = vals[1];
            //int a2 = vals[2];

            //Console.WriteLine(a + a1 + a2);

            //#4
            //b -> a,c
            //d -> c,e
            //a -> z,b
            //A -> Z,B
            //z -> y,a

            //variable  -> dəyişən -> var

            //97-122 a -> 97, z -> 122
            //96
            //char a = 'a';

            //int var = (int)a;

            //int after = var + 1;
            //int before = var - 1;

            //if (before < 'a')
            //{
            //    before = 'z';
            //}
            //else if(after > 'z')
            //{
            //    after = 'a';
            //}

            //Console.WriteLine((char)before);
            //Console.WriteLine((char)after);

            //#3

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());  

            //if (a * a + b * b == c * c)
            //{
            //    Console.WriteLine("Pifaqor ədələridir");
            //}
            //else if(a * a + c * c == b * b) 
            //{
            //    Console.WriteLine("Pifaqor ədələridir");
            //}
            //else if (b * b + c * c == a * a)
            //{
            //    Console.WriteLine("Pifaqor ədələridir");
            //}
            //else
            //{
            //    Console.WriteLine("Pifaqor ədədləri deyil");
            //}

            //int a = int.Parse(Console.ReadLine());

            //if (a % 40 == 0)
            //{
            //    if (a % 9 == 0)
            //    {
            //        if (a % 7 == 0)
            //        {
            //            Console.WriteLine("7-yə bölünür");
            //        }
            //        else
            //        {
            //            Console.WriteLine("9-a bölünür");
            //        }
            //    }
            //    else 
            //    {
            //        Console.WriteLine("40-a bölünür");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Heç birinə bölünmür");
            //}

            //int r = int.Parse(Console.ReadLine());

            //double s = Math.PI * r * r;
            //double l = 2 * Math.PI * r;

            //Console.WriteLine("Sahə:   " + s);
            //Console.WriteLine("Uzunluq:" + l);

            //for, nested for, içə içə dövrlər, while, do while, foreach

            //int n = 10;

            ////i = sətir
            ////j = sütün
            ////i - 2
            //for (int i = 0; i < n; i++)
            //{
            //    //j - 0
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.WriteLine("i:" + i + " j:" + j);
            //    }
            //}


            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("* ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
