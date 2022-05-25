using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists._2.DesignALinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SlinkedList linkedInts = new SlinkedList();
            ListNode nodea = new ListNode(1);
            linkedInts.head = nodea; //current = head
            ListNode nodeb = new ListNode(2);
            nodea.next = nodeb;
            ListNode nodec = new ListNode(3);
            nodeb.next = nodec;
            ListNode noded = new ListNode(4);
            nodec.next = noded;
            ListNode nodee = new ListNode(5);
            noded.next = nodee;

            Console.WriteLine("GetIndex ");
            int getId = linkedInts.get(3);
            Console.WriteLine(getId);

            Console.WriteLine("AddAtHead ");
            linkedInts.addAtHead(7);
            Console.WriteLine(linkedInts.head.val);

            Console.WriteLine("AddAtEnd ");
            linkedInts.addAtEnd(8);

            Console.ReadLine();
        }


        public class SlinkedList
        {
            public ListNode head;
            public int size;

            public SlinkedList()
            {
                ListNode node = new ListNode();
            }

            public int get(int index)
            {
                if (index<0 )// || index>= this.size)
                {
                    return -1;
                }

                ListNode current = head;
                for(int i = 0; i < index; i++)
                {
                     current = current.next;    
                }

                return current.val;
            }

            public void addAtHead(int val)
            {
                ListNode newNode = new ListNode(val);
                newNode.next = head;

                head = newNode;
                size++;

            }

            public void addAtEnd(int val)
            {
                ListNode newNode = new ListNode(val);

                ListNode current = this.head;
                while(current != null && current.next!=null)
                {
                    current = current.next; 
                }
                current.next = newNode;
                size++;
            }

            public void addAtIndex(int val,int index)
            {
                ListNode newNode = new ListNode(val);

                ListNode current = this.head;
                for(int i = 0;i< index;i++)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;

                size++;
            }

            public void delegeAtIndex( int index)
            {
                
                ListNode current = this.head;
                for (int i = 0; i < index; i++)
                {
                    current = current.next;
                }


                current.next = current.next.next;

                size--;
            }
        }
        public class ListNode
        {
            public int val { get; set; }
            public ListNode next { get; set; }

            public ListNode()
            {

            }

            public ListNode(int val)
            {
                this.val = val;
                this.next = null;
            }
        }
    }
}
