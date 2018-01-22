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
                Console.Write("{0} ",head.n);
                Inorder_Recursive(head.right);
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




    }
}
