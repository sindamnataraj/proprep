using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public class BinaryTreeNode {
        public int n;
        public BinaryTreeNode left;
        public BinaryTreeNode right;

        public BinaryTreeNode(int n)
        {
            this.n = n;
        }
    }

    public class BinaryTree
    {
        private BinaryTreeNode head;

        public BinaryTree()
        {
            head = null;
        }

        public void Insert(int n)
        {
            if (head == null)
            {
                head = new BinaryTreeNode(n);
            }
            else
            {
                Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>();
                q.Enqueue(head);
                bool isInserted = false;

                while (q.Count > 0 && !isInserted)
                {
                    BinaryTreeNode current = q.Dequeue();
                    if (current.left != null) q.Enqueue(current.left);
                    if (current.right != null) q.Enqueue(current.right);

                    if (current.left == null)
                    {
                        current.left = new BinaryTreeNode(n);
                        isInserted = true;
                    }

                    if (!isInserted && current.right == null)
                    {
                        current.right = new BinaryTreeNode(n);
                        isInserted = true;
                    }


                }

            }

        }

        public void Levelorder_Traversal() {
            if (head == null) return;
            Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>();
            q.Enqueue(head);
            q.Enqueue(null);

            while (q.Count > 0)
            {
                BinaryTreeNode temp = q.Dequeue();
                if (temp != null)
                {
                    if (temp.left != null) q.Enqueue(temp.left);
                    if (temp.right != null) q.Enqueue(temp.right);
                    Console.Write("{0} ", temp.n);
                }
                else
                {
                    if (q.Count > 0) q.Enqueue(null);
                    Console.WriteLine();
                }
            }

        }

        public void Inorder_Recursive()
        {
            Console.WriteLine("InOrder:");
            Inorder_Recursive(head);
            Console.WriteLine();
        }

        private void Inorder_Recursive(BinaryTreeNode head)
        {
            if (head != null)
            {
                Inorder_Recursive(head.left);
                Console.Write("{0} ", head.n);
                Inorder_Recursive(head.right);
            }
        }

        public void Inorder_NonRecursive()
        {
            Inorder_NonRecursive(head);
        }

        private void Inorder_NonRecursive(BinaryTreeNode Head)
        {
            if (Head == null) return;
            Stack<BinaryTreeNode> s = new Stack<BinaryTreeNode>();

            while (Head != null || s.Count > 0)
            {
                if (Head != null)
                {
                    s.Push(Head);
                    Head = Head.left;
                }
                else
                {
                    Head = s.Pop();
                    Console.Write("{0} ",Head.n);
                    Head = Head.right;
                }
            }
        }

        public void PreOrder_Recursive()
        {
            Console.WriteLine("Pre Order:");
            PreOrder_Recursive(head);
            Console.WriteLine();
        }

        private void PreOrder_Recursive(BinaryTreeNode head)
        {
            if (head != null)
            {
                Console.Write("{0} ",head.n);
                PreOrder_Recursive(head.left);
                PreOrder_Recursive(head.right);
            }
        }

        public void PostOrder_Recursive()
        {
            Console.WriteLine("Post Order:");
            PostOrder_Recursive(head);
            Console.WriteLine();
        }

        private void PostOrder_Recursive(BinaryTreeNode head)
        {
            if (head != null)
            {
                PreOrder_Recursive(head.left);
                PreOrder_Recursive(head.right);
                Console.Write("{0} ", head.n);
            }
        }

        private void PostOrder_NonRecursive(BinaryTreeNode head)
        {
            if (head == null) return;
            Stack<BinaryTreeNode> s = new Stack<BinaryTreeNode>();

            while(head!=null || s.Count>0)
            {
                if (head != null)
                {
                    if (head.right != null) s.Push(head.right);
                    s.Push(head);
                    head = head.left;
                }
                else
                {
                    head = s.Pop();
                    if (s.Count > 0 && s.Peek() == head.right)
                    {
                        BinaryTreeNode temp = head;
                        head = s.Pop();
                        s.Push(temp);
                    }
                    else {
                        Console.Write("{0} ",head.n);
                        head = null;
                    }
                }
            }
        }
        
        //Size of the binary tree
        public int GetSize()
        {
            return GetSize(head);
        }

        private int GetSize(BinaryTreeNode Head)
        {
            if (head == null) return 0;
            return GetSize(head.left) + GetSize(head.right) + 1;
        }

        //max depth/ height of binary tree

        //Find the deepest node in binary tree
        //Level Order traversal
        public int FindDeepest()
        {
            BinaryTreeNode temp = FindDeepest(head);
            if (temp != null) return temp.n;
            return -1;
        }
        private BinaryTreeNode FindDeepest(BinaryTreeNode head)
        {
            if (head == null) return null;
            Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>();
            q.Enqueue(head);
            BinaryTreeNode previous = null;
            BinaryTreeNode current = null;
            while (q.Count > 0)
            {
                
                current = q.Dequeue();
                if (current != null)
                {
                    previous = current;
                    if (current.left != null) q.Enqueue(current.left);
                    if (current.right != null) q.Enqueue(current.right);
                }
                
            }

            return previous;
        }

        //search for number in binary tree
        public bool Search(int n)
        {
            BinaryTreeNode temp = Search(head, n);
            if (temp == null) return false;
            return true;
        }
        private BinaryTreeNode Search(BinaryTreeNode head, int n)
        {
            if (head == null) return null;
            if (head.n == n) return head;
            BinaryTreeNode left = Search(head.left,n);
            if (left != null) return left;
            return Search(head.right,n);
            
        }

        //delete specific node in binary tree

        //number of leave nodes
        public int GetLeavesCount()
        {
            return GetLeavesCount(head, 0);
        }
        private int GetLeavesCount(BinaryTreeNode head,int currentCount)
        {
            if (head == null) return currentCount;
            if (head.left == null && head.right == null) return currentCount + 1;
            return GetLeavesCount(head.left, currentCount) + GetLeavesCount(head.right, currentCount);
        }

        public int GetHalfNodes() {

        }
        private int Gethalfnodes(BinaryTreeNode head, int currentCount)
        {
            if (head == null) return currentCount;


        }
    }
}
