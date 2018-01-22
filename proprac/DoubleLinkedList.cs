using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public class DoubleLinkedListNode
    {
        public int n;
        public DoubleLinkedListNode next;
        public DoubleLinkedListNode prev;

        public DoubleLinkedListNode(int n)
        {
            this.n = n;
            next = null;
            prev = null;    
        }

    }
    public class DoubleLinkedList
    {
        private DoubleLinkedListNode head;
        private DoubleLinkedListNode tail;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
        }

        public void Insert(int n)
        {
            if (head == null && tail == null)
            {
                head = new DoubleLinkedListNode(n);
                tail = head;
            }
            else
            {
                DoubleLinkedListNode temp = new DoubleLinkedListNode(n);
                tail.next = temp;
                temp.prev = tail;
                tail = tail.next;
            }
        }

        public void Traverse()
        {
            DoubleLinkedListNode temp = head;
            while (temp != null)
            {
                Console.Write("{0} ",temp.n);
                temp = temp.next;
            }
        }




    }

}
