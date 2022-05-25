using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists._7.AddIntegersAsList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Input:
            //2-> 2-> 5->X
            //5-> 9-> 2->X

            //Output:
            //7-> 1-> 8->X

            SlinkedList list1 = new SlinkedList();
            ListNode na = new ListNode(2);
            ListNode nb = new ListNode(2);
            ListNode nc = new ListNode(5);
            na.next = nb;
            nb.next = nc;
            nc.next = null;
            list1.head = na;

            SlinkedList list2 = new SlinkedList();
            ListNode nd = new ListNode(5);
            ListNode ne = new ListNode(9);
            ListNode nf = new ListNode(7);
            nd.next = ne;
            ne.next = nf;
            nf.next = null;
            list2.head = nd;

            var newhead = list1.addTwoNumbers(list1.head, list2.head);
        }



        class SlinkedList
        {
            public ListNode head;

            public SlinkedList()
            {
                this.head = new ListNode();
            }

            public ListNode addTwoNumbers(ListNode l1, ListNode l2)
            {
                if (l1 == null)
                    return l2;
                if (l2 == null)
                    return l1;

                if (l1 == null && l2 == null)
                    return null;

                SlinkedList sumList = new SlinkedList();
                sumList.head = new ListNode(-1);
                ListNode current = sumList.head;

                //make sum
                int sum = 0;
                int carry = 0;
                int result = 0;

                while (l1 != null || l2  != null)
                {
                    //make sum

                    //make sum
                    sum = carry;
                    result = 0;

                    int first = (l1 != null) ? l1.val : 0;
                    int second = (l2 != null) ? l2.val : 0;
                    if (sum > 10)
                    {

                        carry = sum / 10; //to get left
                        result= sum % 10; //to get carry
                    }
                    else
                    {
                        result = sum;
                        carry = 0;
                    }
                    

                    current.next = new ListNode(result);
                    current = current.next;
                   
                    //add to new new list output
                    //move ahead to next column sum
                    if (l1 != null)
                    {
                        l1 = l1.next;
                    }
                    if (l2 != null)
                    {
                        l2 = l2.next;
                    }

                }

                if(carry != 0)
                    current.next = new ListNode(carry);

                //current.next.next = null;

                return sumList.head.next;

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
