using System;
using System.Collections.Generic;

namespace Trees
{
    public class Trees
    {
        public static void Main(string[] args)
        {
            //Class of Sunday, Feb 12
            //Concepts: Binary tree, Root node, leaf node, left sub tree, right sub tree, 
            //Traversal(Preorder,Inorder, Postorder, Levelorder)
            //Binary tree has atmost 2 children



        }

        public class TreeNode{
            public int data;
            public TreeNode left;
            public TreeNode right;

            TreeNode(int data){
                this.data = data;
                this.left=null;
                this.right=null;
            }

            TreeNode(int data, TreeNode left, TreeNode right){
                this.data = data;
                this.left = left;
                this.right =right;
            }
        }
    }
}   