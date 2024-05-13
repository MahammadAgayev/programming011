using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class List
    {
        private int[] _data;
        private int _count;

        public int Count
        {
            get { return _count; }
        }

        public int Capacity
        {
            get { return _data.Length; }
        }

        public List()
        {
            _data = new int[1];
        }

        public void Add(int value)
        {
            if (_count == _data.Length)
            {
                int[] newData = new int[_data.Length * 2];

                for (int i = 0; i < _data.Length; i++)
                {
                    newData[i] = _data[i];
                }

                _data = newData;
            }

            _data[_count] = value;
            _count++;
        }

        public void RemoveAt(int index)
        {
            /*
             *   0  1  2  3  4  5  6  7  8 9 10
             * +-------------------------------+
             * | 10 20 30 90 50 60 65 90 0 0 0 |
             * +-------------------------------+
             *  Big O = O(n)
             *  O(1)
             */

            //version 1
            //for(int i = index; i < _count; i++)
            //{
            //    _data[i] = _data[i + 1];
            //}

            //version 2
            _data[index] = _data[_count - 1];
            _count--;
        }

        public int Find(int searchElement)
        {
            for (int i = 0; i < _count; i++)
            {
                if (searchElement == _data[i])
                {
                    return i;
                }
            }

            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_data[i] + " ");
            }

            Console.WriteLine();
        }
    }


    class GenericList<T>
    {
        private T[] _data;

        private int _count;

        public GenericList() 
        {
            _data = new T[1];
        }


        public int Count
        {
            get { return _count; }
        }

        public int Capacity
        {
            get { return _data.Length; }
        }

        public void Add(T item)
        {
            if (_count == _data.Length)
            {
                T[] newData = new T[_data.Length * 2];

                for (int i = 0; i < _count; i++)
                {
                    newData[i] = _data[i];
                }

                _data = newData;
            }

            _data[_count] = item;
            _count++;
        }

        public void RemoveAt(int index)
        {
            /*
             *   0  1  2  3  4  5  6  7  8 9 10
             * +-------------------------------+
             * | 10 20 30 90 50 60 65 90 0 0 0 |
             * +-------------------------------+
             *  Big O = O(n)
             *  O(1)
             */

            //version 1
            for (int i = index + 1; i < _count; i++) {
                _data[i - 1] = _data[i];
            }

            //version 2
            //_data[index] = _data[_count - 1];
            _count--;

            checkAndDecreaseCapacity();
        }

        private void checkAndDecreaseCapacity()
        {
            if (_count > _data.Length / 4)
            {
                return;
            }

            T[] newData = new T[_data.Length / 2];

            for (int i = 0; i < _count; i++)
            {
                newData[i] = _data[i];
            }

            _data = newData;
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_data[i] + " ");
            }

            Console.WriteLine();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Data structures
            //Verilənlərin saxlanma forması
            //arraylar

            //List - Data Structure
            //LinkedList

            // 12 -> 5 -> 6 -> null

            //List l = new List();
            //l.Add(10);
            //l.Add(20);
            //l.Add(30);
            //l.Add(40);
            //l.Add(50);
            //l.Add(60);
            //l.Add(70);
            //l.Add(80);
            //l.Add(90);

            //Console.WriteLine(l.Count);
            //Console.WriteLine(l.Capacity);

            //l.RemoveAt(3);

            //l.Print();

            //GenericList<string> strings = new GenericList<string>();
            //strings.Add("Hello,");
            //strings.Add("It's me,");
            //strings.Add("Are you looking for me");

            //strings.Print();

            GenericList<byte> bytes = new GenericList<byte>();
            bytes.Add(1);
            bytes.Add(2);
            bytes.Add(3);
            bytes.Add(4);
            bytes.Add(5);
            bytes.Add(6);
            bytes.Add(7);
            bytes.Add(8);

            bytes.Print();
            Console.WriteLine("Capacity: " + bytes.Capacity);
            Console.WriteLine("Count: " + bytes.Count);

            bytes.RemoveAt(0);
            bytes.RemoveAt(0);
            bytes.RemoveAt(0);
            bytes.RemoveAt(0);
            bytes.RemoveAt(0);
            bytes.RemoveAt(0);
            bytes.RemoveAt(0);

            bytes.Print();
            Console.WriteLine("Capacity: " + bytes.Capacity);
            Console.WriteLine("Count: " + bytes.Count);

            //Write your own list implementation at home
            //LinkedList

            /*
             *  root Node       Node             Node`
             * +------+       +------+        +------+        +------+
             * | 1    |       | 2    |        | 3    |        | 4    |
             * | Next | --->  | Next |  --->  | Next |  --->  | Next |  --> null
             * +------+       +------+        +------+        +------+
             */

            //Optional homework
            //Queue/Stack
        }
    }
}
