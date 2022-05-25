using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovekthToLastNode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode nodea = new ListNode(1);
            ListNode nodeb = new ListNode(2);
            ListNode nodec = new ListNode(3);
            ListNode noded = new ListNode(4);
            ListNode nodee = new ListNode(5);

            SLinkedList list1 = new SLinkedList();
            list1.head = nodea;
            nodea.next = nodeb;
            nodeb.next = nodec;
            nodec.next = noded;
            noded.next = nodee;

            list1.RemoveKthToLast(list1.head,3);

        }

        public class SLinkedList
        {
            public ListNode head;
            public int size;

            public SLinkedList()
            {
                head = new ListNode();
            }

            public ListNode RemoveKthToLast(ListNode head, int k)
            {

                //[dummyHead] --> a   --> x
                //   |            |       |
                //   |           head     |
                // LowPtr               HighPtr

                //dummy node
                ListNode dummyhead = new ListNode(-1);
                dummyhead.next = head;

                //two pointers to create window k+1 and edge case 1 to point to previous
                ListNode lowPointer = dummyhead;
                ListNode highPointer = dummyhead.next;

                //move high pointer until widow is created
                while(k>0)
                {
                    highPointer = highPointer.next;
                    k--;
                }

                //move window til end
                while(highPointer!=null)
                {
                    lowPointer = lowPointer.next;
                    highPointer = highPointer.next; 
                }

                //remove kth node
                lowPointer.next = lowPointer.next.next;

                return dummyhead.next; //in case of null

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
