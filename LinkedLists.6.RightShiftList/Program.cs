using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists._6.RightShiftList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SlinkedList list = new SlinkedList();
            ListNode na = new ListNode(1);
            ListNode nb = new ListNode(2);
            na.next = nb;
            ListNode nc = new ListNode(3);
            nb.next = nc;
            ListNode nd = new ListNode(4);
            nc.next = nd;

            list.head = na; 

            var newhead =list.ShiftRightK(list.head,2);

        }


        class SlinkedList
        {
            public ListNode head;

            public SlinkedList()
            {
                this.head = new ListNode();
            }

            public ListNode ShiftRightK(ListNode head,int k)
            {

                if (head == null)
                    return head;


                ListNode oldListTail = head;
                //determine length of list
                int listSize = 1;

                while(oldListTail.next!=null)
                {
                    listSize++;
                    oldListTail = oldListTail.next;
                    
                }

                //if k>listsize for multiple cycles determine steps until new tail
                k = k % listSize;


                if(k== 0)
                    return head;


                //cycle the list
                oldListTail.next = head;
                 
                ListNode newTail = oldListTail;

                int newKsteps = listSize- k;
                while(newKsteps > 0)
                {
                    newTail =newTail.next;
                    newKsteps--;
                }

                ListNode newHead =newTail.next;
                newTail.next = null;

                return newHead;

            }
        }

        class ListNode
        {
            public int val;
            public ListNode next;

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
