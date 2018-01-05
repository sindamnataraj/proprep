using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public static class utility
    {
        public static void swap(int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        public static void showarray(int[] A)
        {
            foreach (var item in A)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }

        public static void showarray_vertical(int[] A)
        {
            foreach (var item in A)
            {
                Console.WriteLine("{0} ", item);
            }
            Console.WriteLine();
        }

        public static int getNthDigit(int A,int n)
        {
            return (A / (int)(Math.Pow((int)10, (int)n - 1))) % 10;
        }
    }
}
