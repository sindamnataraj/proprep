using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public static class sorting
    {
        //o(n2)
        public static int[] selectionsort(int[] A)
        {
            for (int i = 0; i < A.Length-1; i++)
            {
                int curSmall = i;
                for (int j = i+1; j < A.Length; j++)
                {
                    if (A[j] < A[curSmall]) curSmall = j; 
                }

                if (curSmall != i) utitlity.swap(A, i, curSmall);

            }

            return A;
        }

        public static void insertionsort(int[] A)
        {
            int i = 0;
            while (i < A.Length-1)
            {
                
                int k = A[i + 1];
                int j = i;

                while (j > -1 && A[j] > k)
                {
                    A[j+1] = A[j];
                    j--;
                }

                A[j + 1] = k;
                i++;

            }
        }

        public static void bubblesort(int[] A)
        {
            for (int j = A.Length - 1; j > 0; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (A[i] < A[i - 1]) utitlity.swap(A, i, i - 1);
                }
            }
        }

        public static void quicksort(int[] A, int p, int q)
        {
            if (p < q)
            {
                int r = partition(A, p, q);
                quicksort(A, p, r - 1);
                quicksort(A, r + 1, q);
            }
        }

        private static int partition(int[] A, int p, int q)
        {
            int i = p - 1;
            int k = A[q];
            int j = p;

            while(j<q)
            {
                if (A[j] <= k)
                {
                    utitlity.swap(A, i + 1, j);
                    i++;
                }
                j++;
            }

            A[q] = A[i + 1];
            A[i + 1] = k;
            return i + 1;
        }

        public static void mergesort(int[] A, int p, int q)
        {
            if (p < q)
            {
                int r = p + (q - p) / 2;
                mergesort(A, p, r);
                mergesort(A, r+1, q);
                merge(A, p, r, q);
            }
        }

        public static void merge(int[] A, int p, int r,int q)
        {
            int len1 = r - p + 1;
            int len2 = q - r;
            

            int[] left = new int[len1];
            int[] right = new int[len2];

            for (int i1 = 0; i1 < left.Length; i1++)
            {
                left[i1] = A[i1 + p];
            }

            for (int i2 = 0; i2 < right.Length; i2++)
            {
                right[i2] = A[r + 1 + i2];
            }


            int i = 0;
            int j = 0;
            int k = p;

            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    A[k] = left[i];
                    i++;
                }
                else {
                    A[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < len1)
            {
                A[k] = left[i];
                i++;
                k++;
            }

            while (j < len2)
            {
                A[k] = right[j];
                j++;
                k++;
            }




        }



    }
}
