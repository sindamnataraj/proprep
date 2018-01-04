using System;

namespace proprac
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 25, 23, 4, 12, 1, 145 };

            sorting.mergesort(A,0,A.Length-1);
            utitlity.showarray(A);

            Console.ReadLine();
        }
    }
}
