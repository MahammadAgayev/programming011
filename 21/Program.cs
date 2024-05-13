using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
    }

    class Stack<T>
    {
        //push O(n)
        //pop O(n)

        //push O(1)
        //pop  O(1)
        //Double LinkedList

        private Node<T> _head;
        private Node<T> _tail;


        public void Push(T value)
        {
            if (_head == null)
            {
                _head = new Node<T> { Value = value };

                _tail = _head;

                return;
            }

            Node<T> node = new Node<T> { Value = value };

            _tail.Next = node;
            node.Prev = _tail;

            _tail = node;

            /*
             *  
             *  +--------+     +--------+      +--------+   +--------+
             *  |        | <-  |        |  <-  |        |   |        |
             *  |  head  | ->  |        |  ->  |  tail  | ->|  node  |
             *  +--------+     +--------+      +--------+   +--------+
             */
        }

        public T Pop()
        {
            if (_head == null || _tail == null)
            {
                Console.WriteLine("There's no element in stack");

                //if T is int then this value will be 0
                //if T is string then this value will be null
                return default;
            }

            T val = _tail.Value;

            Node<T> newTail = _tail.Prev;
            if (newTail == null)
            {
                _head = null;
                _tail = null;
                return val;
            }

            if (newTail == _head)
            {
                _head.Next = null;
                _head.Prev = null;
                _tail = _head;

                return val;
            }

            newTail.Next = null;
            _tail.Prev = null;

            _tail = newTail;

            return val;
            /*
             *  
             *  +--------+     +--------+      +--------+   +--------+
             *  |        | <-  |        |  <-  |        |   |        |
             *  |  head  | ->  |        |  ->  | tail   |   |  tail  |
             *  +--------+     +--------+      +--------+   +--------+
             *                                   newTail
             */
        }

        public T Peek()
        {
            if (_tail == null)
            {
                Console.WriteLine("there's no element in the stack");

                return default;
            }

            return _tail.Value;
        }
    }

    class Queue<T>
    {
        private T[] _data;

        private int _head;
        private int _tail;

        public Queue()
        {
            _data = new T[1];
        }

        public void Enqueue(T val)
        {
            if (_data.Length == _tail)
            {
                T[] newData = new T[_data.Length * 2];

                for (int i = 0; i < _tail; i++)
                {
                    newData[i] = _data[i];
                }

                _data = newData;
            }

            _data[_tail] = val;
            _tail++;
        }


        public T Dequeue()
        {
            if(_head == _tail)
            {
                Console.WriteLine("There's no element in the queue");

                return default;
            }

            T val = _data[_head];

            _head++;

            this.resizeQueue();

            return val;
        }

        private void resizeQueue()
        {
            int count = _tail - _head;

            if (count >= _data.Length * 0.25)
            {
                return;
            }

            T[] newData = new T[_data.Length / 2];

            for (int i = 0; i < count; i++)
            {
                newData[i] = _data[_head + i];
            }

            _data = newData;
            _head = 0;
            _tail = count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Queue Stack

            //Array, LinkedList


            //Queue -> FIFO first in first out
            //Stack -> LIFO last in first out

            //Queue -> 1,2,3,4,5
            //1

            //Stack -> 1,2,3,4,5
            //5

            //Queue -> Enqueue
            //         Dequeue

            //Stack -> Push
            //      -> Pop

            Stack<string> stack = new Stack<string>();

            stack.Push("Hello");
            stack.Push("World");
            stack.Push("This is where you are");

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());


            //Write stack using array

            //Queue 

            /*
             *  _count 
             *  _head = 0
             * 
             *  | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13 | data
             *    0   1   2   3   4   5   6   7   8   9    10   11   12
             *                                      _head                _tail 
             *                                      
             *  | 9 | 10 | 11 | 12 | 13 |  newData
             *    0    1    2    3    4
             *  _head               _tail
             *  
             *  newData[0] = data[8 + 0]
             *  
             *  newData[1] = data[8 + 1]
             *  newData[2] = data[8 + 2]
             */

            Queue<string> queue = new Queue<string>();

            //Big O enqueue
            //Big O dequeue

            queue.Enqueue("Hello");
            queue.Enqueue("World");
            queue.Enqueue("Hello");
            queue.Enqueue("Programming");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
