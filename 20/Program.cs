using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Node
    {
        public Node(int data)
        {
            this.Data = data;
        }

        //auto property
        public int Data { get; set; }
        public Node Next { get; set; }
    }

    class LinkedList
    {
        private Node _root;

        public void AddLast(int data)
        {
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }

            Node iter = _root;
            while (iter.Next != null)
            {
                iter = iter.Next;
            }

            iter.Next = new Node(data);
        }

        public void AddFirst(int data)
        {
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }

            Node newRoot = new Node(data);

            newRoot.Next = _root;
            _root = newRoot;
        }

        public void RemoveAt(int index)
        {
            if(_root == null)
            {
                return;
            }

            Node iter = _root;

            int count = 1;
            while(count < index)
            {
                iter = iter.Next;
                count++;
            }

            Node temp = iter.Next;
            //1 -> 3
            iter.Next = temp.Next;
            //2 -> 3 => 2 -> null
            temp.Next = null;
        }

        public void Print()
        {
            Node iter = _root;

            while (iter != null)
            {
                Console.Write(iter.Data + " ");
                iter = iter.Next;
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

        public void Add(T item)
        {
            if (_count >= _data.Length)
            {
                T[] newData = new T[_data.Length * 2];

                for (int i = 0; i < _data.Length; i++)
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
            if (index >= _count)
            {
                return;
            }
            //1 2 3 4 5
            //1 2 4 5
            //1 2 4 5

            for (int i = index + 1; i < _count; i++)
            {
                _data[i - 1] = _data[i];
            }

            _count--;
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
            //list, generic list
            //array

            //int[] arr = new int[10];
            ////Generic list
            //List<int> ints = new List<int>();
            ////Non generic list
            //ArrayList list = new ArrayList();

            //ints.Clear();
            //ints.Remove(4);

            //ints.Add(5);

            //List<int> ints = new List<int>();

            //GenericList<bool> bools = new GenericList<bool>();

            //bools.Add(true);
            //bools.Add(false);
            //bools.Add(false);
            //bools.Add(true);

            //bools.RemoveAt(2);

            //bools.Print();

            //Why we cannot resize array

            /*
             * +----------------+ 
             * |                |
             * +----------------+
             * 
             */

            //
            //Add:     O(1)
            //Remove:  O(n) -> O(1)

            //LinkedList
            /*
             *      root Node       Node             Node`         last
             *     +------+       +------+        +------+        +------+
             *     | 1    |       | 2    |        | 3    |        | 4    |
             *     | Next | --->  | Next |  --->  | Next |  --->  | Next |  --> null
            null<- | Prev | <---  | Prev |  <---  | Prev |  <---  | Prev |  
             *     +------+       +------+        +------+        +------+
             *      head                                             tail
             */

            //Simple LinkedList, Root
            //Double LinkedtList, Head,Tail

            //Big O LinkedList: 
            //Add last on simple LinkedList: O(n)
            //Add last on double LinkedList: O(1)

            //LinkedList AddFirst: O(1)
            //Double LinkedList AddFirst: O(1)

            /*
             *                 +----+
             *              -> |    | --
             *              |  +----+  V
             *  +----+    +----+    +----+    +----+
             *  |    | -> |    |    |    | -> |    | -> null
             *  +----+    +----+    +----+    +----+
             */

            //List insert: O(n) = Find O(1) + insert O(n)
            //LinkedList insert: = Find O(n) + insert O(1)
            //Double LinkedtList: = Find O(n) + insert O(1)


            //Circular LinkedList
            /*
             * 
             *  +----+    +----+    +----+    +----+    
             *  |    | -> |    | -> |    | -> |    | 
             *  +----+    +----+    +----+    +----+ 
             *     ^                              |
             *     |______________________________|
             *  
             */

            //Code of simple LinkedList
            LinkedList data = new LinkedList();

            data.AddLast(1);
            data.AddLast(2);
            data.AddFirst(0);
            data.AddLast(3);

            data.RemoveAt(2);

            data.Print();


            //LinkedList
            /*
             *               ^------------------v
             *  +----+    +----+    +----+    +----+ 
             *  | 0  | -> | 1  |    | 2  |    | 3  | -> null
             *  +----+    +----+    +----+    +----+ 
             *             iter
                           iter.next = iter.next.next
             *   index: 2 
             *   count: 2
             */
        }
    }
}