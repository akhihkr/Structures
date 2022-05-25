using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists._1.fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SlinkedList singleList = new SlinkedList();
            ListNode a  = new ListNode(1);
            singleList.head = a;
            ListNode b = new ListNode(2);
            a.next = b;
            ListNode c = new ListNode(3);
            b.next = c;
            ListNode d = new ListNode(4);
            c.next = d;
            ListNode e = new ListNode(5);
            d.next = e;


            //Console.WriteLine("PrintLinkedList");
            //singleList.PrintLinkedList(a);

            //Console.WriteLine("PrintLinkedListRecursive");
            //singleList.PrintLinkedListRecursive(a);

            //Console.WriteLine("PrintLinkedListReverse");
            //singleList.PrintLinkedListReverse(a);

            //Console.WriteLine("PrintLinkedListReverseRecursive");
            //singleList.PrintLinkedListReverseRecursive(a);

            //Console.WriteLine("ReverseList");
            //ListNode reversedhead = singleList.ReverseList(a);
            //singleList.PrintLinkedList(reversedhead);

            //Console.WriteLine("ReverseListRecursive");
            //ListNode reverseListRecursive = singleList.ReverseListRecursive(a);
            //singleList.PrintLinkedList(reverseListRecursive);

            Console.WriteLine("GetMiddleNode");
            ListNode getMiddleNode = singleList.GetMiddleNode(a);
            Console.WriteLine(getMiddleNode.val);

            Console.WriteLine("KthToLastElement");
            ListNode kthToLastElement = singleList.KthToLastElement(a,3);
            Console.WriteLine(kthToLastElement.val);

            Console.WriteLine("DeepCopy");
            ListNode deepCopy = singleList.DeepCopy(a);
            singleList.PrintLinkedList(deepCopy);

            Console.ReadLine();

        }

        public class SlinkedList
        {
            public ListNode head;
            public int size;

            public SlinkedList()
            {
                head = new ListNode();
            }

            public void PrintLinkedList(ListNode head)
            {
                ListNode pointer = head;
                while (pointer != null)
                {
                    Console.WriteLine(pointer.val);
                    pointer = pointer.next;
                }

            }

            public void PrintLinkedListRecursive(ListNode head)
            {
                if (head == null)
                {
                    return;
                }
                Console.WriteLine(head.val);
                PrintLinkedListRecursive(head.next);
                
            }

            public void PrintLinkedListReverse(ListNode head)
            {
                Stack<ListNode> stacked = new Stack<ListNode>();
                
                while(head != null)
                {
                    stacked.Push(head);
                    head= head.next;
                }

                while(stacked.Count>0)
                {
                    ListNode currentNode = stacked.Pop();
                    Console.WriteLine(currentNode.val);
                }

            }

            public void PrintLinkedListReverseRecursive(ListNode head)
            {
                if(head==null)
                {
                    return;
                }

                PrintLinkedListReverseRecursive(head.next);

                Console.WriteLine(head.val);
            }

            public ListNode ReverseList(ListNode head)
            {
                //initialise pointers
                ListNode prev = null;
                ListNode curr = head;
                ListNode temp = null;

                //iterate until current != end i.e end of list
                while(curr != null)
                {
                    //reassign pointers
                    temp = curr.next;
                    curr.next = prev;

                    //move to the right
                    prev = curr;
                    curr = temp;

                }
                return prev;

            }

            public ListNode ReverseListRecursive(ListNode curr)
            {
                if (curr == null)
                {
                    return curr;
                }

                if (curr.next ==null)
                {
                    return curr;
                }
                ListNode nodeStack = ReverseListRecursive(curr.next);

                curr.next.next = curr;
                curr.next = null;

                return nodeStack;

            }

            public ListNode GetMiddleNode(ListNode head)
            {
                //have two pointers slow fast = 2*slow movement point to head
                ListNode slowPtr = head;
                ListNode fastPtr = head;

                //travese fast until end i.e null
                while(fastPtr !=null &&  fastPtr.next!=null)
                {
                    slowPtr = slowPtr.next;
                    fastPtr = fastPtr.next.next;
                }

                //when fast ptr will be at end slow will be in mid
                return slowPtr;
            }

            public ListNode KthToLastElement(ListNode head,int k)
            {
                //slide a window size K until end
                ListNode lowPtr=head;
                ListNode highPtr=head;
                
                //make the window
                for(int i=0;i<k;i++)
                {
                    highPtr= highPtr.next;
                }

                while(highPtr!=null && highPtr.next!=null)
                {
                    lowPtr = lowPtr.next;
                    highPtr = highPtr.next;
                }

                return lowPtr;//as kth to last element
            }

            public ListNode DeepCopy(ListNode head)
            {
                //old pointer to old head
                ListNode oldCurrent = head;
                //new pointer to new head
                ListNode newHead = new ListNode(-1);//dummy node
                ListNode newCurrent = newHead;

                //traverse list and create new node and assign it.
                while(oldCurrent!=null)
                {
                    ListNode tempNode = new ListNode(oldCurrent.val+1);

                    //assign newcurrent to created node
                    newCurrent.next = tempNode;

                    //move old new pointers
                    oldCurrent = oldCurrent.next;
                    newCurrent = newCurrent.next;
                }

                return newHead.next;//skip dummy node created
            }
        }
        public class ListNode
        {
            public int val { get; set; }
            public ListNode next { get; set; }


            public ListNode() { }

            public ListNode(int val)
            {
                this.val = val;
                this.next = null;
            }

        }
    }
}
