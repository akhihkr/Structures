
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree._1.BinaryTreeSymmetric
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(2);

            Console.WriteLine(root.isSymmetric(root));

            TreeNode root2 = new TreeNode(1);
            root2.Left = new TreeNode(2);
            root2.Right = new TreeNode(2);

            Console.WriteLine(root.isSymmetric(root));

        }
    }

    public class TreeNode
    {
        public int Val;
        public TreeNode Left, Right;

        public TreeNode()
        {
            
        }

        public TreeNode(int Val)
        {
            this.Val = Val;
            this.Left = null;  
            this.Right = null;  
        }

        public bool isSymmetric(TreeNode root)
        {
            if (root.Left == null && root.Right==null)
            {
                return false;
            }

            return checkSimillar(root.Left, root.Right);
        }

        public bool checkSimillar(TreeNode rootLeft, TreeNode rootRight)
        {
            if (rootLeft == null || rootRight == null)
                return true;


            if (rootLeft != null || rootRight != null)
            {
                return rootLeft.Val == rootRight.Val &&
                checkSimillar(rootLeft.Left, rootRight.Right) &&
                checkSimillar(rootLeft.Right, rootRight.Left);
            }
              

            return false;
        }

        //public isSymmetricIterative(TreeNode rootLeft, TreeNode rootRight)
        {


        }
    }



}
