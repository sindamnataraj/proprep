using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    /// <summary>
    /// Implementation of custom stack as well as problems related to stack
    /// </summary>
    public class mystack
    {
        private int[] A;
        private int top;

        public mystack(int n)
        {
            A = new int[n];
            top = -1;
        }

        public void Push(int num)
        {
            if (top == A.Length - 1) return;
            A[top + 1] = num;
            top++;
        }

        public int Peek()
        {
            if (top == -1) return int.MinValue;
            return A[top];
        }

        public int Pop()
        {
            if (top == -1) return int.MinValue;
            int k = A[top];
            top--;
            return k;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">A + (B * C)</param>
        /// <returns></returns>
        public static string Infix_to_postfix(string A)
        {
            StringBuilder sb = new StringBuilder();
            if (A.Length <3) return sb.ToString();

            Stack<char> s = new Stack<char>();
            var d = GetPriorityDictionary();

            foreach (char c in A)
            {
                if (char.IsNumber(c))
                {
                    sb.Append(c);
                }
                else if (IsOperator(c) || IsLeftRound(c))
                {
                    while (s.Count > 0 && (d[s.Peek()] >= d[c]))
                    {

                        sb.Append(s.Pop());
                    }
                    s.Push(c);
                }
                else
                {
                    //right round 
                    while (s.Count > 0 && !IsLeftRound(s.Peek()))
                    {
                        sb.Append(s.Pop());
                    }
                    if (s.Count > 0) s.Pop();
                }

            }

            return sb.ToString();


        }

        private static Dictionary<char, int> GetPriorityDictionary()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            d.Add('1', 0);
            d.Add('2', 0);
            d.Add('3', 0);
            d.Add('4', 0);
            d.Add('5', 0);
            d.Add('6', 0);
            d.Add('7', 0);
            d.Add('8', 0);
            d.Add('9', 0);

            d.Add('+',1 );
            d.Add('-', 1);

            d.Add('*', 2);
            d.Add('/', 2);

            d.Add('(', 3);
            d.Add(')', 3);

            return d;
        }

        private static bool IsLeftRound(char c)
        {
            if (c == '(') return true;
            return false;
        }

        private static bool IsrightRound(char c)
        {
            if (c == ')') return true;
            return false;
        }

        private static bool IsOperator(char c)
        {
            if (c == '*' || c == '/' || c == '+' || c == '-') return true;
            return false;
        }
    }
}
