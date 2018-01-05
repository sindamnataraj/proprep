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

            
            sorting.radixsort(C, 2);
            utility.showarray(C);

            Console.ReadLine();
        }
    }
}
