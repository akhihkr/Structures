using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees._0.Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {

           BST bst = new BST();

            /* Let us create following BST
                   50
                /     \
               30      70
              /  \    /  \
            20   40  60   80 */

            bst.insertRecursive( 50);
            bst.insertRecursive(30);
            bst.insertRecursive(20);
            bst.insertRecursive(40);
            bst.insertRecursive(70);
            bst.insertRecursive(60);
            bst.insertRecursive(80);

            /*
                 10
                 / \
                2   7
                    / \
                    3   12
            */
            BST bst2 = new BST();
            bst2.root = new TreeNode(10);
            bst2.root.Left = new TreeNode(2);
            bst2.root.Left.Left = null;
            bst2.root.Left.Right = null;
            bst2.root.Right = new TreeNode(7);
            bst2.root.Right.Left = new TreeNode(3);
            bst2.root.Right.Right = new TreeNode(12);

            bst2.checkValidBST(bst2.root,long.MinValue,long.MaxValue);

            //bst.InOrderTraversalDisplay(bst.root);

            Console.WriteLine(bst.checkValidBST(bst2.root, long.MinValue, long.MaxValue));

        }

        public class BST
        {
            public TreeNode root;

            public BST() { }
            public BST(int val) { root   = new TreeNode(val); }


            public void insertRecursive(int Val) { this.root=insertingRecursive(this.root, Val); }

            public TreeNode insertingRecursive(TreeNode root, int Val)
            {
                //base case for adding root
                if(root == null)
                {
                    return root= new TreeNode(Val);
                }

                if(Val<root.Val)
                {
                    root.Left = insertingRecursive(root.Left, Val);
                }
                else
                {
                    root.Right = insertingRecursive(root.Right, Val);
                }
                return root;
            }

            public bool checkValidBST(TreeNode root,long minVal,long maxVal)
            {

                if (root == null)
                    return true;
                else if (root.Val >= maxVal && root.Val <= minVal)
                    return false;
                return checkValidBST(root.Left,minVal,root.Val) && checkValidBST(root.Right, root.Val,maxVal);

            }

            public bool twoSum()
            {
                SortedDictionary<int, int> treemap = new SortedDictionary<int, int>();
                return true;
            }

        }

        public class TreeNode
        {
            public int Val;
            public TreeNode Left, Right;

            public TreeNode() { }
            public TreeNode(int val) 
            { 
                this.Val = val;
                this.Left = null;
                this.Right = null; 
            } 

        }
    }
}
