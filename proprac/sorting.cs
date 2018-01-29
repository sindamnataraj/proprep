using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public static class sorting
    {
        //SIBQMBRH

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

                if (curSmall != i) utility.swap(A, i, curSmall);

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
                    if (A[i] < A[i - 1]) utility.swap(A, i, i - 1);
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
                    utility.swap(A, i + 1, j);
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

        //A contains numbers 0-9 only => k = 10
        public static int[] countingsort(int[] A)
        {
            int k = 10;
            int[] C = new int[k];
            int[] B = new int[A.Length]; //Result array

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = 0;
            }

            for (int i = 0; i < A.Length; i++)
            {
                C[A[i]]++;
            }

            for (int i = 1; i < C.Length; i++)
            {
                C[i] = C[i] + C[i - 1];
            }

            for (int i = 0; i < A.Length; i++)
            {
                B[C[A[i]] - 1] = A[i];
                C[A[i]]--;
            }

            return B;
        }

        //d is number of digits in each number
        public static void radixsort(int[] A, int d)
        {
            for (int i = 1; i <= d; i++)
            {
                countingsort_radixsort(A, i);
            }
        }

        public static void countingsort_radixsort(int[] A,int d)
        {
            int k = 10;
            int[] C = new int[k];
            int[] B = new int[A.Length]; //Result array

            Array.Copy(A, B, A.Length);

            for (int i = 0; i < C.Length; i++)
            {
                C[i] = 0;
            }

            for (int i = 0; i < B.Length; i++)
            {
                int number = utility.getNthDigit(B[i],d);
                C[number]++;
            }

            for (int i = 1; i < C.Length; i++)
            {
                C[i] = C[i] + C[i - 1];
            }

            for (int i = 0; i < B.Length; i++)
            {
                int number = utility.getNthDigit(B[i], d);
                A[C[number] - 1] = B[i];
                C[number]--;
            }

            
        }


        //Heap Sort
        public static void HeapSort(int[] A)
        {
            BuildMaxHeap(ref A);
            int heapLength = A.Length - 1;

            while (heapLength >= 0)
            {
                Swap(ref A, 0, heapLength);
                MaxHeapify(ref A, 0, --heapLength);
                
            }
            utility.showarray(A);
        }
        private static void BuildMaxHeap(ref int[] A)
        {
            int HeapLength = A.Length - 1;
            for (int i = (A.Length / 2) - 1; i >= 0; i--)
            {
                MaxHeapify(ref A, i, HeapLength);
            }
        }
        private static void MaxHeapify(ref int[] A, int i, int heapLength)
        {
            int left = Left(i);
            int right = Right(i);
            int MaxIndex = i;
            if (left <= heapLength && A[left] > A[i])
            {
                MaxIndex = left;
            }
            else
            {
                MaxIndex = i;
            }

            if (right <= heapLength && A[right] > A[MaxIndex])
            {
                MaxIndex = right;
            }

            if (MaxIndex != i)
            {
                Swap(ref A, MaxIndex, i);
                MaxHeapify(ref A, MaxIndex, heapLength);
            }
        }
        private static void Swap(ref int[] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }
        private static int Left(int i)
        {
            return (2 * i) + 1;
        }
        private static int Right(int i)
        {
            return (2 * i) + 2;
        }


    }
}
