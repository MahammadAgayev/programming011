using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Helo World");
            //integer -> int
            //floating point -> float
            //int x = 5;
            //float y = 5.4f;

            //type  variable assign value
            //int    a         =      5;

            //int is 4 byte = 32 bit

            //11111111111......
            //2^31 + 2^30 + 2^29

            //31 bit
            //sign bit
            //short a1 = 19;
            //65536

            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(short.MaxValue);
            //Console.WriteLine(long.MaxValue);
            ////64 byte = 64 * 8 = 2^8=

            //Console.WriteLine(ushort.MaxValue);

            //short c = -10;

            //byte  = 1 byte = 8 bit = 255

            //Console.WriteLine(byte.MaxValue);

            //sbyte s = -127;

            //Console.WriteLine(sbyte.MaxValue);

            //bool bl = false; //1 bit
            //bool bl2 = true;

            //char c3 = 'a';
            //1 byte
            //Console.WriteLine((byte)c3);

            //Unicode
            //65535 symbol
            //2 byte

            //Console.OutputEncoding = Encoding.UTF8;
            //char c4 = 'ə';
            //2 byte
            //Console.WriteLine(c4);
            //conversion
            //Console.WriteLine((short)c4);

            //string s1 = "Unlimited text";

            //double, float, decimal

            //float f = 12.5f;
            //double d = 15.6d;
            //decimal dc = 134.7m;

            //float   4 byte
            //double  8 byte
            //decimal 16 byte

            //int x = -213232;
            //int y = 9848952365653465;

            //int type gets 4 byte

            //1 bit 
            //1 byte = 8 bit
            //1 KB   = 1024 byte
            //1 MB   = 1024 KB
            //1 GB   = 1024 MB

            //1 MB = 1024 * 1024 byte

            //2-lik say sistemi
            //5 =
            //
            // 0   0
            // 1   1
            // 2   10
            // 3   11
            // 4   100
            // 5   101
            // 6   110
            // 7   111
            // 8   1000

            // 1  0  1 = 2^0 * 1 + 2^1 * 0 + 2^2 * 1 = 5
            // *  *  *
            // 2  1  0
            // ^  ^  ^
            // 2  2  2

            //1 0 1 0 0 1 1 1
            //* * * * * * * *
            //7 6 5 4 3 2 1 0
            //^ ^ ^ ^ ^ ^ ^ ^
            //2 2 2 2 2 2 2 2

            //= 1 + 2 + 4 + 32 + 128 = 167

            //5 = 
            /* 
             *   5 | 2
             *   4 ----
             *  ---  2 |2
             *   1  --- ---
             *       0   1
             *     <----
             *   101
             *   
             *   5 = 101
             *   
             *   6 = 110
             *   
             *   167 - 128 = 39 - 32 = 7 - 4 = 3
             *   167 = 10100111
             *   
             *   259 = 10000011
             *   
             *   194 = 11000010 
             *         76543210 = 2+ 64 + 128 = 194
             *   11100011 = 1 + 2 + 32 + 128 + 64 = 
             *   76543210
             *   
             *   138 = 
             *   
             *   1100010 = 2 + 32 + 64 = 98
             *   1000101 = 64 + 1 + 8 = 
             *   10001010 = 138
             *   
             *   FFF 16lıq say sistem
             *   
             *   hexadecimal  0 1 2 3 4 5 6 7 8 9 A B C D E F
             */

            //  1111 = 1 + 2 + 4 + 8 = 15 = F

            // 10001010 = 1000 1010 = 8A


            int a = 15;
            long l = a;

            long b = 3000000000;
            int t = (int)b;
            Console.WriteLine(t);

            //char c = 'A';
            int d = 119378232;
            //Console.WriteLine(d);
            //char e = (char)d;
            //Console.WriteLine(e);

            //kriptoqrafiya
            //caeser cipher
            //key: 3
            //A -> D
            //D -> G

            //Homework, write code to shift any symbol by given key, For example: key = 3
        }
    }
}
