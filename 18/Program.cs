using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //what is object on memory
            //listlər, genericlər

            //value type
            //reference type

            //stack heap

            //int a = 5;
            //SetAToHundred(a);
            //Console.WriteLine(a);

            //Person p = new Person();
            //p.Age = 5;
            //SetAgeToHundred(p);
            //Console.WriteLine(p.Age);
            /* 
             *  stack           heap
             *  +------+    +-------------+
             *  | a: 5 |    |1: Person obj|
             *  | p: 1 |    |             |
             *  | a:100|    |             |
             *  | p: 1 |    |             |
             *  +------+    +-------------+
             *  
             *  stack           heap
             *  +------+    +-------------+
             *  | p1: 2|    |1: "Hello"   |
             *  |      |    |2:"Not Hello"|
             *  |      |    |             |
             *  |      |    |             |
             *  +------+    +-------------+
             */

            //immutable
            //string p1 = "Hello";
            //string p2 = " World";

            //p1 = "Not Hello";


            //string res = p1 + p2;
            //Console.WriteLine(res);

            //lists and generics

            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);
            //dinamik arrays

            //int[] a = new int[1];
            //int[] a1 = new int[2];

            //int[] a3 = new int[4];
            //int[] a4 = new int[8];
            //int[] a5 = new int[16];

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //ArrayList list = new ArrayList();

            //list.Add("Hello");
            //list.Add(1);
            //list.Add(true);
            //list.Add(2.689);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //    item = false;
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);

            //    //list[i] = false;
            //}

            //genericlər

            ArrayList list = new ArrayList();


            object o = 5;
            int a = (int)o;

            bool b = true;
            object o2 = b;


            /*
             *  Stack         Heap
             *   o: 1         1: 5
             *   a: 5  unboxed(unboxing)
             *   
             *   b:true
             *   o2:2          2:true boxed(boxing)
             */

            List<bool> bools = new List<bool>();
            bools.Add(true);
            //bools.Add("Hello");

            List<Person> people = new List<Person>();

            people.Add(new Person());

            List<int> ints = new List<int>();

            List<int> ints2 = new List<int>()
            {
                1,2,3,4,
            };

            ints2.AddRange(new int[] { 9, 4, 6 });

            //foreach (var item in ints2)
            //{
            //    Console.WriteLine(item);
            //}


            //ints2.Clear();
            //Console.WriteLine(ints2.Count);
            //Console.WriteLine(ints2.Capacity);

            //remove element with matching value
            ints2.Remove(4);
            //removes element with matching index
            ints2.RemoveAt(0);

            //foreach (var item in ints2)
            //{
            //    Console.WriteLine(item);
            //}

            ints2.Insert(1, 250);
            foreach (int i in ints2)
            {
                Console.WriteLine(i);
            }

            ints2.Sort();
        }

        static void SetAToHundred(int a)
        {
            a = 100;
        }

        static void SetAgeToHundred(Person p)
        {
            p.Age = 100;
        }
    }
}
