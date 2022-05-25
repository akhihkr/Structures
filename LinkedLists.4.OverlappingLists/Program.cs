using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists._4.OverlappingLists
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
            ListNode nodef = new ListNode(6);
            ListNode nodeg = new ListNode(7);
            ListNode nodeh = new ListNode(8);

            //1-2-3-
            //      5-6
            //    4-
            SLinkedList list1 = new SLinkedList();
            list1.head = nodea;
            nodea.next = nodeb;
            nodeb.next = nodec;
            nodec.next = nodee;
            nodee.next = nodef;

            SLinkedList list2 = new SLinkedList();
            list2.head = noded;
            noded.next = nodee;

            ListNode commonNode = list1.GetOverlap(list1.head, list2.head);
        }

        public class SLinkedList
        {
            public ListNode head;
            public int size;

            public SLinkedList()
            {
                head = new ListNode();
            }

            public ListNode GetOverlap(ListNode head1 ,ListNode head2)
            {
                
                ListNode headPtr1 = head1;
                ListNode headPtr2 = head2;
                int sizeHead1 = 0;
                int sizeHead2 = 0;

                if (head1 == null || head2 == null)
                {
                    return null;
                }

                //get length head1
                while(headPtr1 != null )//&& headPtr1.next != null)
                {
                    headPtr1 = headPtr1.next;
                    sizeHead1++;
                }

                //get length head2
                while (headPtr2 != null )//&& headPtr2.next != null)
                {
                    headPtr2 = headPtr2.next;
                    sizeHead2++;
                }

                headPtr1 = head1;
                headPtr2 = head2;

                int delta = Math.Abs(sizeHead2 - sizeHead1);

                if (delta > 0)
                {
                    //move  greater size header to delta
                    if(sizeHead2>sizeHead1)
                    {
                        for(int i=0;i<delta;i++)
                        {
                            headPtr2 = headPtr2.next;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < delta; i++)
                        {
                            headPtr1 = headPtr1.next;
                        }
                    }
                    
                }

                while(headPtr1 != null || headPtr2!=null)
                {
                    
                    if(headPtr1.val == headPtr2.val)
                        return headPtr1;

                    headPtr1 = headPtr1.next;
                    headPtr2 = headPtr2.next;

                }

                return null; 



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
