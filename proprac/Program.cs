using System;

namespace proprac
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 25, 23, 4, 12, 1, 145 };
            int[] B = { 9, 0, 9, 8, 3, 0, 1, 8, 3 };
            int[] C = { 25, 23, 41, 12, 11, 45 };

            LinkedList L = new LinkedList();
            L.Insert(1);
            L.Insert(2);
            L.Insert(3);
            L.Insert(4);
            L.Insert(5);
            L.Reverse();
            L.PrintList();

            Console.Read();
        }
    }
}
