using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _24
{
    class Value
    {
        public int X { get; set; }
    }

    //struct is value type
    struct ValuePair
    {
        public ValuePair(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int A { get; set; }
        public int B { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //reference types, values types

            /*
             *     stack              heap
             *    +--------+         +------------------+
             *    | Main   |         | A7:"Hello"       |
             *    |  a:5   |         | A8:"World"       |
             *    |  s:A8  |         |                  |
             *    | ------ |         |                  |
             *    |  Square|         |                  |
             *    |  a:25  |         |                  |
             *    |        |         |                  |
             *    +--------+         +------------------+
             */

            //

            //Value types
            //int a = 5;
            //Square(a);
            //Console.WriteLine(a);

            //reference type
            /*
             *    stack              heap
             *   +--------+         +------------------+
             *   | Main   |         | A7: {X = 25}     |
             *   |  v:A7  |         |                  |
             *   | ------ |         |                  |
             *   |  Square|         |                  |
             *   |  v:A7  |         |                  |
             *   |        |         |                  |
             *   +--------+         +------------------+
             */

            //Value v = new Value
            //{
            //    X = 5
            //};

            //Square(v);
            //Console.WriteLine(v.X);

            //int a = 5;

            //SquareRef(ref a);
            //Console.WriteLine(a);

            /*
             *    stack              heap
             *   +--------+         +------------------+
             *   | Main   |         | A7:1kb           |
             *   |  a:A7  |         |                  |
             *   | ------ |         |                  |
             *   |  Square|         |                  |
             *   |  a:A7  |         |                  |
             *   |        |         |                  |
             *   +--------+         +------------------+
             */


            //int a = 10;
            //Increase(ref a);

            //Console.WriteLine(a);

            //int a = 10;
            //int b = 12;

            //Swap(ref a, ref b);

            //Console.WriteLine(a);
            //Console.WriteLine(b);


            //Value v = new Value();
            //v.X = 5;
            //Square2(ref v);
            //Console.WriteLine(v.X);

            /*
             *    stack              heap
             *   +--------+         +------------------+
             *   | Main   |         | A7:A9            |
             *   |  v:A7  |         | A8:A9            |
             *   | ------ |         |                  |
             *   |  Square|         | A9:{X=25}        |
             *   |  v:A8  |         |                  |
             *   +--------+         +------------------+
             */

            //ref 
            //out

            //int a;

            //ReadNumber(out a);
            //ReadNumberPair(out int a, out int b);

            //Console.WriteLine($"Read {a} and {b}");

            //if (TryToFetchMoney(out decimal amount))
            //{
            //    Console.WriteLine($"Amount fetched {amount}");
            //}
            //else
            //{
            //    Console.WriteLine("There's an issue with fetching money");
            //}

            //int a = int.Parse(Console.ReadLine());
            //string s = Console.ReadLine();

            //if (int.TryParse(s, out int result))
            //{
            //    Console.WriteLine("Parsed: "+ result);
            //} 
            //else
            //{
            //    Console.WriteLine("Cannot parse input data, please only insert numnbers");
            //}

            ValuePair pair = new ValuePair();
            pair.A = 12;
            pair.B = 20;

            Console.WriteLine(pair.A);
            Console.WriteLine(pair.B);

            Swap(pair);

            Console.WriteLine(pair.A);
            Console.WriteLine(pair.B);
        }

        static void Swap(ValuePair p)
        {
            int temp = p.A;
            p.A = p.B;
            p.B = temp;
        }

        static void ReadNumber(out int x)
        {
            x = int.Parse(Console.ReadLine());
        }

        static int ReadNumber2()
        {
            return int.Parse(Console.ReadLine());
        }

        static void ReadNumberPair(out int a, out int b)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        }

        static void SquareRef(ref int a)
        {
            a *= a;
        }


        static bool TryToFetchMoney(out decimal amount)
        {
            amount = 100;

            return true;
        }

        static void Square(int a)
        {
            a *= a;
        }

        static void Square(Value b)
        {
            b.X *= b.X;
        }

        static void Square2(ref Value v)
        {
            v = new Value
            {
                X = v.X * v.X
            };
        }

        static void Increase(ref int a)
        {
            a++;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
