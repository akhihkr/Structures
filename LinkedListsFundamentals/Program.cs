using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsFundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
        }

        public class ListNode 
        {
            int val { get; set; }
            ListNode next { get; set; }

            public ListNode() { }

            public ListNode(int val)
            {
                this.val = val;

            }
        }

        public class SLinkedList
        {
            ListNode node { get; set; }
            int size { get; set; }  


        }

    }



}
