using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public static class utitlity
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
    }
}
