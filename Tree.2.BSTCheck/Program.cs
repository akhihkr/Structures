using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree._2.BSTCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        public class BST 
        { 
            TreeNode root;
        }


        public class TreeNode
        {
            public int Val;
            public int Left, Right;

            public TreeNode(){}

            public TreeNode(int Val)
            {
                this.Val = Val; 
            }

        }
    }
}
