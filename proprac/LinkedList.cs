using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    
    public class LinkedList
    {
        public class LinkedListNode {
            public int n;
            public LinkedListNode next;

            public LinkedListNode(int n)
            {
                this.n = n;
                next = null;
            }
        }


        private LinkedListNode head;
        private LinkedListNode tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void Insert(int n)
        {
            head = Insert(head, n);      
        }

        private LinkedListNode Insert(LinkedListNode head, int n)
        {
            if (head == null) return new LinkedListNode(n);
            head.next = Insert(head.next, n);
            return head;
        }


        public void PrintList()
        {
            PrintList(head);
        }

        private void PrintList(LinkedListNode head)
        {
            if (head == null) Console.WriteLine();
            else
            {
                Console.Write("{0} ",head.n);
                PrintList(head.next);
            }
        }

        //Delete

        //Reverse
        public void Reverse()
        {
            head = Reverse(head);
        }

        private LinkedListNode Reverse(LinkedListNode node)
        {
            if (node == null || node.next == null) return node;
            LinkedListNode first = node;
            LinkedListNode second = node.next;

            LinkedListNode reverseOfSecond = Reverse(second);
            second.next = first;
            first.next = null;
            return reverseOfSecond;
        }



    }
}
