using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class TreeNode
    {
        public TreeNode(int val)
        {
            this.Value = val;
        }

        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }

    class BinarySearchTree
    {
        private TreeNode _root;

        public void Add(int val)
        {
            if (_root == null)
            {
                _root = new TreeNode(val);
                return;
            }

            TreeNode iter = _root;

            while (true)
            {
                if (val >= iter.Value)
                {
                    if (iter.Right == null)
                    {
                        iter.Right = new TreeNode(val);
                        break;
                    }
                    else
                    {
                        iter = iter.Right;
                    }
                }
                else
                {
                    if (iter.Left == null)
                    {
                        iter.Left = new TreeNode(val);
                        break;
                    }
                    else
                    {
                        iter = iter.Left;
                    }
                }
            }

            //iter.Next != null
            //
            /*
             *           (12)
             *       (5)       (17)
             *              (15) 
             */
        }

        public TreeNode Find(int val)
        {
            if (_root == null)
            {
                return null;
            }

            TreeNode iter = _root;

            while (iter != null)
            {
                if (iter.Value == val)
                {
                    return iter;
                }
                else if (iter.Value > val)
                {
                    iter = iter.Right;
                }
                else
                {
                    iter = iter.Left;
                }
            }

            return null;
        }

        public void Print()
        {
            PrintRecurse(_root);
            Console.WriteLine();
        }

        private void PrintRecurse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PrintRecurse(root.Left);
            Console.Write(root.Value + " ");
            PrintRecurse(root.Right);
        }
        
        public void Remove(int val)
        {
            this.RemoveRecurse(_root, val);
        }

        //binary space partitioning
        private TreeNode RemoveRecurse(TreeNode root, int value)
        {
            if (root == null)
                return null;

            if  (value < root.Value)
            {
                root.Left = RemoveRecurse(root.Left, value);
            }
            else if(value > root.Value)
            {
                root.Right = RemoveRecurse(root.Right, value);
            }
            else
            {
                if(root.Left == null)
                {
                    return root.Right;
                }
                else if(root.Right == null)
                {
                    return root.Left;
                }

                root.Value = MinValue(root.Right);
                root.Right = RemoveRecurse(root.Right, root.Value);
            }

            return root;
        }

        private int MinValue(TreeNode node)
        {
            int minValue = node.Value;
            while(node.Left != null)
            {
                minValue = node.Left.Value;
                node = node.Left;
            }

            return minValue;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Binary Tree + Tree traversal
            //Binary Search Tree , Insert Delete Find

            BinarySearchTree tree = new BinarySearchTree();

            tree.Add(12);
            tree.Add(5);
            tree.Add(17);
            tree.Add(15);

            tree.Remove(12);
            tree.Print();
            //TreeNode val = tree.Find(38);

            //if (val == null)
            //{
            //    Console.WriteLine("Do not exists");
            //}
            //else
            //{
            //    Console.WriteLine(val.Value);
            //}

            /*
             *              (15)
             *       (12)                (23)
             *    (10)  (14)      (17)             (25)
             *  (5)   (13)            (19)      (24)    (30)
             *                     (18)            
             *                     
             *                     
             *             (9)
             *      (5)             (16)
             *   (3)   (7)      (13)    (18)
             *                        (17)   (20)
             *                      (16)
             *                          root.Right = null;
             */
        }
    }
}
