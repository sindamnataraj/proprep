using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public class BinarySearchTree
    {
        public class BinarySearchTreeNode
        {
            public int val;
            public BinarySearchTreeNode left;
            public BinarySearchTreeNode right;

            public BinarySearchTreeNode(int n)
            {
                this.val = n;
            }
        }

        private BinarySearchTreeNode head;

        public BinarySearchTree()
        {
            head = null;
        }

        public void Insert(int n)
        {
            head = Insert(head, n);
        }
        private BinarySearchTreeNode Insert(BinarySearchTreeNode head, int n)
        {
            if (head == null) return new BinarySearchTreeNode(n);

            if (n <= head.val)
                head.left = Insert(head.left, n);
            else
                head.right = Insert(head.right, n);

            return head;
        }

        public void Inorder()
        {
            Inorder(head);
            Console.WriteLine();
        }
        private void Inorder(BinarySearchTreeNode head)
        {
            if (head != null)
            {
                Inorder(head.left);
                Console.Write("{0} ", head.val);
                Inorder(head.right);
            }
        }

        public bool Search(int n)
        {
            return search(head, n);
        }
        private bool search(BinarySearchTreeNode head, int n)
        {
            if (head == null) return false;
            if (head.val == n) return true;
            if (n < head.val) return search(head.left, n);
            return search(head.right, n);
        }

        public int FindMinimum()
        {
            return FindMinimum(head);
        }
        private int FindMinimum(BinarySearchTreeNode head)
        {
            if (head == null) return int.MinValue;
            if (head.left == null) return head.val;
            return FindMinimum(head.left);
        }

        public int FindMaximum()
        {
            var res = FindMaximum(head);
            if (res != null) return (int)res;
            return -9999;
        }
        private int? FindMaximum(BinarySearchTreeNode Head)
        {
            if (Head == null) return null;
            if (Head.right == null) return Head.val;

            Int64 x = Int64.MinValue;
            int a = 1;
            if (a > x)
            {

            }

            return FindMaximum(Head.right);

            
        }

        


    }
}
