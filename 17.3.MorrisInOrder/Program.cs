using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._3.MorrisInOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             *![](DC73877D512FC4C762F269564342B766.png;;;0.03024,0.02650) 
             *  Approach:

                When we are currently at a node, the following cases can arise:

                Case 1: When the current node has no left subtree. In this scenario, there is nothing to be traversed on the left side, so we simply print the value of the current node and move to the right of the current node.
                Case 2: When there is a left subtree and the right-most child of this left subtree is pointing to null. In this case we need to set the right-most child to point to the current node, instead of NULL and move to the left of the current node.
                Case 3: When there is a left subtree and the right-most child of this left-subtree is already pointing to the current node. In this case we know that the left subtree is already visited so we need to print the value of the current node and move to the right of the current node.
                Note: Case 3 is very important as we need to remove the new links added to restore the original tree. 
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

            List<int> preOrder = new List<int>();
            preOrder = root.PreOrderMorrisIterate(root, new List<int>());

            for (int i = 0; i < preOrder.Count(); i++)
            {
                Console.Write(preOrder[i] + "-");
            }

            Console.ReadLine();
        }


    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val, TreeNode left=null, TreeNode right=null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public List<int> PreOrderMorrisIterate(TreeNode curr, List<int> list)
        {
            while(curr != null)
            {
                //case 1 curr left null process right val
                if (curr.left == null)
                {
                    list.Add(curr.val);
                    curr = curr.right;
                }
                else
                {
                    //case 2
                    
                    TreeNode prev = curr.left;

                    //find right most connect to curr check threaded to avoid loop
                    while (prev.right != null && prev.right != curr)
                    {
                        prev = prev.right;
                    }
                    if(prev.right==null)//last node
                    {
                            
                        prev.right = curr;
                        curr = curr.left;
                    }
                    else// thread exist move to right
                    {
                        prev.right = null; //reset thread
                            
                        list.Add(curr.val);

                        curr = curr.right;
                    }
                    
                }
            }

            return list;
        }
    }
}
