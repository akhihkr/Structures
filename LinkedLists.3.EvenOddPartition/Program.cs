using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists._3.EvenOddPartition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode nodea = new ListNode(1);

            ListNode nodeb = new ListNode(2);
            nodea.next = nodeb;
            ListNode nodec = new ListNode(3);
            nodeb.next = nodec;
            ListNode noded = new ListNode(4);
            nodec.next = noded;
            ListNode nodee = new ListNode(5);
            noded.next = nodee;

            SLinkedList sLink = new SLinkedList();
            sLink.head = nodea;


            oddEvenList(nodea);

        }

        public static ListNode oddEvenList(ListNode head)
        {

            //edge case

            if(head==null || head.next==null)
            {
                return head;
            }

            ListNode evenPtr = head;
            ListNode oddPtr = head.next;
            ListNode oddHead = oddPtr;

            while(oddPtr != null && oddPtr.next!=null   )
            {
                evenPtr.next = oddPtr.next;
                evenPtr = oddPtr.next;
                oddPtr.next = evenPtr.next;
                oddPtr = evenPtr.next;
            }

            evenPtr.next = oddHead;


            return head;



        }

        public class SLinkedList
        {
            public ListNode head;

            public SLinkedList()
            {
                ListNode node = new ListNode();
            }
        }
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode()
            {
                
            }

            public ListNode(int val)
            {
                this.val = val;
            }
        }
    }
}
