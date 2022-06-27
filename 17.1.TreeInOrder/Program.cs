using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2.TreeInOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             ![](21234A0051BFCD174D677E9222CB72C7_1.png;;;0.02116,0.02102)
             */


            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.right.left = new TreeNode(8);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);
            root.right.right.left = new TreeNode(9);
            root.right.right.right = new TreeNode(10);

            
            IList<int> list = new List<int>();

            list = Solution.InOrderTraversalIterative(root);

            for(int i = 0; i < list.Count; i++)
            { 
                Console.Write(list[i].ToString() + " - ");
            }

            Console.WriteLine();


            IList<int> list2 = new List<int>();

            list2 = Solution.InOrderRecursive(root,new List<int>());

            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i].ToString() + " - ");
            }

        }
    }

    public class Solution
    {
        public static IList<int> InOrderTraversalIterative(TreeNode root)
        {

            List<int> listInOrder = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();
            
            //lets traverse the tree
            while(true)
            {
                //move to left
                if(root!=null)
                {
                    //lets add it into the stack to backtrack later
                    stack.Push(root);
                    root = root.left;
                }
                else//move right
                {
                    //caution we stop if stack is empty
                    if (stack.Count <= 0)
                        break;

                    //visit root by pointing back to top stack backtracking
                    root= stack.Pop();
                    //add to our list to return later
                    listInOrder.Add(root.val);

                    //move right
                    root = root.right;

                }

                

                

            }

            return listInOrder;

        }

        public static IList<int> InOrderRecursive(TreeNode root,List<int> listInorder)
        {
            if (root == null)
                return null;

            InOrderRecursive(root.left,listInorder);
            listInorder.Add(root.val);
            InOrderRecursive(root.right,listInorder);

            return listInorder;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val,TreeNode left =null,TreeNode right =null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
