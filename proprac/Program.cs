using System;
using System.Collections.Generic;
using System.Linq;

namespace proprac
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "12";
            bool ssd = (s == "12");

            #region BT
            //BinaryTree bt = new BinaryTree();
            //bt.Insert(1);
            //bt.Insert(2);
            //bt.Insert(3);
            //bt.Insert(4);
            //bt.Insert(5);
            //bt.Insert(6);
            //bt.Insert(7);
            //bt.Levelorder_Traversal();
            //bt.GetVerticalSum();
            #endregion

            #region BST
            //BinarySearchTree bst = new BinarySearchTree();
            //bst.Insert(5);
            //bst.Insert(2);
            //bst.Insert(3);
            //bst.Insert(9);
            //bst.Insert(7);
            //bst.Insert(10);
            //bst.Inorder();



            #endregion

            int[] A = { 10, 11, 2, 1, 5, 1, 0 };
            sorting.HeapSort(A);

            Console.Read();

        }


        private static int GetMiddle(int length)
        {
            if (length % 2 == 0)
            {
                return (length - 1) / 2;
            }
            else
            {
                return length / 2;
            }

        }
    }
}
