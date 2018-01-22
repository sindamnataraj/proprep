using System;
using System.Collections.Generic;
using System.Text;

namespace proprac
{
    public class LinkedListNode {
        public LinkedListNode prev;
        public int n;
        public LinkedListNode next;

        public LinkedListNode(int n)
        {
            this.n = n;
            next = null;
        }
    }

    public class LinkedList
    {
        private LinkedListNode head;
        private LinkedListNode tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void Insert(int n)
        {
            if (head == null && tail == null)
            {
                LinkedListNode temp = new LinkedListNode(n);
                head = temp;
                tail = temp;
            }
            else {
                tail.next = new LinkedListNode(n);
                tail = tail.next;
            }
        }

        public void PrintLinkedList()
        {
            LinkedListNode temp = head;
            while (temp != null)
            {
                Console.Write("{0} ", temp.n);
                temp = temp.next;
            }
            Console.WriteLine();
        }


        //delete node
        
        
        //reverse list


    }
}
