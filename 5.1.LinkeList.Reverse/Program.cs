using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1.LinkeList.Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            ListNode two = new ListNode(2);
            head.next = two;
            ListNode three = new ListNode(3);
            two.next = three;   
            ListNode four = new ListNode(4);
            three.next = four;
            ListNode five = new ListNode(5);
            four.next = five;
            

            head.reverseList(head);

        }

        
    }

    /**
 * Definition for singly-linked list.*/
  public class ListNode 
  {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next; 
      }


     public ListNode reverseList(ListNode head)
    {
            if (head == null)
                return head;

            //set 3 pointers
            ListNode prev = null;
            ListNode curr = head;

            //traverse whole List and reverse
            while(curr != null)
            {
                //save next not to lose it
                ListNode nex = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nex;
            }
            return prev;
    }
  }
 
}
