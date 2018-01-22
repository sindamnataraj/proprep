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
            BinaryTree bt = new BinaryTree();
            bt.Insert(1);
            bt.Insert(2);
            bt.Insert(3);
            bt.Insert(4);
            bt.Insert(5);
            bt.Insert(6);
            bt.Insert(7);

            bt.Levelorder_Traversal();

            bt.Inorder_Recursive();

            bt.Inorder_NonRecursive();

            Console.Read();
        }
    }
}
