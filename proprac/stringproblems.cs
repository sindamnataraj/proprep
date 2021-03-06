﻿using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public class stringproblems
    {

        public static string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            Reverse(ref sb, 0, s.Length - 1);
            return sb.ToString();
        }

        public static void Reverse(ref StringBuilder sb, int i, int j)
        {
            while (i < j)
            {
                char c = sb[i];
                sb[i] = sb[j];
                sb[j] = c;

                i++;
                j--;
            }
        }

        public static void ReverseSentenceWords(ref StringBuilder sb)
        {
            int i = 0;
            int j = 0;

            while (j < sb.Length)
            {
                while ( j < sb.Length && sb[j] != ' ')
                {
                    j++;
                }

                Reverse(ref sb, i, j - 1);

                if (j < sb.Length)
                {
                    i = j + 1;
                    j++;
                }
            }
            

        }

        public static void Permute(StringBuilder sb, int p, int q)
        {
            if (p == q)
            {
                Console.WriteLine(sb.ToString());
                return;
            }

            if (p < q)
            {
                
                for (int i = p; i <= q; i++)
                {
                    swap(ref sb, p, i);
                    Permute(sb, p + 1, q);
                    swap(ref sb, p, i);
                }
            }
        }

        private static void swap(ref StringBuilder sb, int i, int j)
        {
            char c = sb[i];
            sb[i] = sb[j];
            sb[j] = c;
        }
    }
}
