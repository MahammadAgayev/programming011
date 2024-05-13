using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    class LinkedList
    {
        private Node _root;

        public void Add(int val)
        {
            if (_root == null)
            {
                _root = new Node() { Value = val };
                return;
            }

            Node iter = _root;


            while (iter.Next != null)
            {
                iter = iter.Next;
            }

            iter.Next = new Node { Value = val };
        }

        public void Print()
        {
            Node iter = _root;

            while (iter != null)
            {
                Console.Write(iter.Value + " ");
                iter = iter.Next;
            }

            Console.WriteLine();
        }

        public int Middle()
        {
            Node rabbit = _root;
            Node turtle = _root;

            while (rabbit != null && rabbit.Next != null)
            {
                rabbit = rabbit.Next.Next;
                turtle = turtle.Next;
            }

            return turtle.Value;
        }
    }

    class TreeNode
    {
        public TreeNode(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //list 
            //generic list 
            //linkedlist
            //double linkedlist
            //circular linkedlist 

            //queue
            //stack

            //find middle in the given linkedlist
            //O(n)
            // 1 -> 2 -> 3 -> 4 -> 5
            //                     |
            //           |
            // rabbit and turtle
            LinkedList l = new LinkedList();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);

            //l.Print();

            //Console.WriteLine(l.Middle());

            //
            //reverse linked list
            // 1 -> 2 -> 3 -> 4 -> 5
            // 1 <- 2 <- 3 <- 4 <- 5
            // 5 -> 4 -> 3 -> 2 -> 1

            //list vs linkedlist
            //

            //Binary tree
            /*
             * Node: Left Right
             *  
             *           +----+
             *           | 12 | 
             *           +----+
             *    +----+         +----+
             *    | 13 |         |  14| 
             *    +----+         +----+
             * +----+  +----+  +----+  +----+
             * |  1 |  | 0  |  |  5 |  |  8 | 
             * +----+  +----+  +----+  +----+
             *    
             *    BT
             *   BST = Binary search tree
             *   
             *   
             *            +----+ 
             *            | 17 |  
             *            +----+ 
             *     +----+         +----+ 
             *     | 13 |         | 22 |  
             *     +----+         +----+ 
             *  +----+  +----+  +----+  +----+ 
             *  |  12|  | 15 |  |  20|  | 25 |  
             *  +----+  +----+  +----+  +----+ 
             *  leaf nodes
             *  
             *  Search speed O(logn)
             *  worst case O(n)
             */

            TreeNode root = new TreeNode(12);
            root.Right = new TreeNode(14);
            root.Left = new TreeNode(13);

            root.Right.Left = new TreeNode(5);
            root.Right.Right = new TreeNode(8);

            root.Left.Left = new TreeNode(1);
            root.Left.Right = new TreeNode(0);

            //tree traversal
            //left traversal
            //right traversal
            //middle traversal

            //Traverse(root);
            TraverseQueue(root);
            Console.WriteLine();
        }

        static void Traverse(TreeNode root)
        {
            if (root == null) return;

            Console.Write(root.Value + " ");
            Traverse(root.Right);
            Traverse(root.Left);
        }

        static void TraverseQueue(TreeNode root)
        {

            //12
            //13 14
            //14 1 0 
            //1 0 5 8

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                TreeNode n = q.Dequeue();
                Console.Write(n.Value + " ");

                if (n.Left != null)
                {
                    q.Enqueue(n.Left);
                }
                if (n.Right != null)
                {
                    q.Enqueue(n.Right);
                }
            }
        }
    }
}
