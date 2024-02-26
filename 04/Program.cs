using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ceasar cipher

            //char a = 'b';

            ////Console.WriteLine(a);
            //int a1 = (int)a;
            //a1 = a1 + 2;

            //char b = (char)a1;

            //Console.WriteLine(b);

            //int a = 5;
            //int b = 9;

            //Console.WriteLine(a + b);

            //int d = 10;
            //int z = 9;

            //int result = d - z;

            ////declaration
            //int result2 = result + 10;
            //result2 = result2 + 2;

            //Console.WriteLine(result2);

            //int a = 4;

            //int x1 = 5;

            //int x2 = x1 * a;
            //int x3 = x2 / 2;

            //int x4 = (x2 + x3) / x1;

            //Console.WriteLine(x2);
            //Console.WriteLine(x3);
            //Console.WriteLine(x4);

            //int x1 = 4;
            //int x2 = 19;

            //int x3 = x2 / x1;
            //int x4 = x2 % x1;

            //int x5 = x4 % x3;

            //Console.WriteLine(x3);
            //Console.WriteLine(x4);
            //Console.WriteLine(x5);

            //x5++;
            //Console.WriteLine(x5);
            //x5--;
            //Console.WriteLine(x5);            //int x1 = 4;
            //int x2 = 19;

            //int x3 = x2 / x1;
            //int x4 = x2 % x1;

            //int x5 = x4 % x3;

            //Console.WriteLine(x3);
            //Console.WriteLine(x4);
            //Console.WriteLine(x5);

            //x5++;
            //Console.WriteLine(x5);
            //x5--;
            //Console.WriteLine(x5);

            //int x = 5;

            //x++;
            //++x;
            //x--;
            //--x;
            //Console.WriteLine(x);

            //>, <, >=, <=, ==
            //   operand   operator     operand
            //int x = 1 + 2;

            //int a = 4 + 5;

            //bool b = 4 > 5;
            //bool b1 = 4 == 5;
            //Console.WriteLine(b);
            //Console.WriteLine(b1);

            //int a = 40;
            //int b = 40;
            //int c = 32;
            //bool b2 = a >= b;

            //məntiqi operator (logical operators)
            // && məntiqi və
            // || məntiqi və ya

            //bool b3 = a >= b && b > c;
            //bool b4 = a == b && b > c;
            //bool b5 = a > b || b > c;
            //Console.WriteLine(b3);
            //Console.WriteLine(b4);
            //Console.WriteLine(b5);

            //bool b6 = a > b || b > c;

            //Console.WriteLine(b6);

            //int a = 5;
            //int b = 9;
            //int c = 1;

            //bool b1 = !(a < b && b < c) || a < c;
            //Console.WriteLine(!b1);

            //bit operators (bitwise operators)
            // & bit and
            // | bit or

            //int a = 5;
            //int b = 9;
            //int c = 1;

            //bool b1 = !(a < b & b < c) | a < c;
            ////Console.WriteLine(b1);

            //int a = 5;
            //int b = 4;

            //int c = 5 & 4;
            ////101
            ////    &
            ////100
            ////100 = 4

            ////101
            ////    |
            ////100
            ////101  = 5

            //int c1 = a | b;
            //Console.WriteLine(c1);

            //int x1 = 100;
            //int x2 = 163;

            //int x3 = x1 & x2;
            //int x4 = x1 | x2;
            ////163 - 128 = 35=3

            ////     10100011
            ////     01100100
            ////x3 = 00100000 = 32

            ////     10100011
            ////     01100100
            ////x4 = 11100111

            //Console.WriteLine(x3);
            //Console.WriteLine(x4);

            ////^ xOr  = xor
            ////1 ^ 1 = 0
            ////1 ^ 0 = 1
            ////0 ^ 0 = 0

            //int x5 = x1 ^ x2;

            //     10100011
            //     01100100
            //x5 = 11000111 = 199
            //Console.WriteLine(x5);
            //ctrl + k, c for comment
            //ctrl + k, u for uncomment
            //int a = 123;     //11110110
            //int b = a << 1; 
            //int c = a >> 1; 

            //Console.WriteLine(b);
            //Console.WriteLine(c);

            // = assign, == 
            //int a = 5;
            //Console.WriteLine(a);

            ////a = a + 5;
            //a += 5;
            //a -= 5;
            //a *= 5;
            //a /= 5;

            //Console.WriteLine(a);

            //int b = 5;
            //int c = ++b;
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            int a = 5;
            int b = ++a + ++a;

            Console.WriteLine(b);

            //?: ternary operator
            int x1 = 100;
            int x2 = 101;

            int a1 = x1 > x2 ? x1 : x2;

            Console.WriteLine(a1);
        }
    }
}
