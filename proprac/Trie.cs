using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public class Trie
    {
        public class TrieNode {
            public bool IsEnd;
            public TrieNode[] Child;

            public TrieNode()
            {
                IsEnd = false;
                Child = new TrieNode[26];
            }
        }


        private TrieNode Head;

        public Trie()
        {
            Head = null;
        }


        public void Insert(string s)
        {
            Head = Insert(Head, s, 0);
        }

        private static TrieNode Insert(TrieNode Head, string s, int i)
        {
            if (Head == null)
            {
                Head = new TrieNode();
            }

            if (i == s.Length)
            {
                Head.IsEnd = true;
                return Head;
            }
            int index = (int)s[i] - 97;

            Head.Child[index] = Insert(Head.Child[index], s, i + 1);
            return Head;
        }


        public void PrintAll()
        {
            List<string> result = new List<string>();
            PrintTrie(Head, new StringBuilder(), ref result);

            foreach (var item in result)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }

        private static void PrintTrie(TrieNode head, StringBuilder sb,ref List<string> result)
        {
            if (head == null) return;

            if (head.IsEnd == true) result.Add(sb.ToString());
            for (int i = 0; i < 26; i++)
            {
                char c = (char)(i + 97);
                if (head.Child[i] != null)
                {
                    StringBuilder newSb = new StringBuilder();
                    newSb.Append(sb);
                    newSb.Append(c);
                    PrintTrie(head.Child[i], newSb, ref result);
                }
            }
        }
    }
}
