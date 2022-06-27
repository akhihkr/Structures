using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._2.TreePreOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              ![](F811807426B4D16F7DAEFC0E8FD3002C.png;;;0.02150,0.01768)
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
            preOrder = root.PreOrderRecurse(root, new List<int>());

            
            for (int i = 0; i < preOrder.Count(); i++)
            {
                Console.Write(preOrder[i] + "-");
            }

            List<int> preOrder2 = new List<int>();
            preOrder2 = root.PreOrderIterative(root);


            for (int i = 0; i < preOrder2.Count(); i++)
            {
                Console.Write(preOrder2[i] + "-");
            }



            Console.ReadLine();
        }

    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val, TreeNode left =null, TreeNode right =null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public List<int> PreOrderRecurse(TreeNode curr,List<int> listPre)
        {
            if (curr == null)
                return null;

            //root
            listPre.Add(curr.val);

            //left
            PreOrderRecurse(curr.left, listPre);

            //right
            PreOrderRecurse(curr.right, listPre);

            return listPre;
        }

        public List<int> PreOrderIterative(TreeNode curr)
        {
            List<int> listPre = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            while(true)
            {
                //Process Curr Node
                if(curr!=null)
                {
                    stack.Push(curr);
                    listPre.Add(curr.val);

                    //left
                    curr = curr.left;
                }
                else //right
                {
                    if (stack.Count <= 0)
                        break;

                    curr = stack.Pop();
                    curr = curr.right;
                }

            }

            return listPre;
        }
    }
}
