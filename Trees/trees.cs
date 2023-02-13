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

            TreeNode lnode = new TreeNode{
                val=9, left=new TreeNode{val=1,right=null,left=null }, right= new TreeNode{val=2,right=null,left=null }
            };
            TreeNode rnode = new TreeNode{
                val=20, left=new TreeNode{val=15,right=null,left=null }, right= new TreeNode{val=7,right=null,left=null }
            };
            TreeNode tree = new TreeNode{
                val=3, left=lnode, right= rnode
            };

            //ulerTraversal(tree);
            preorderTraversal(tree);
            
        }

        public class TreeNode{
            public int val;
            public TreeNode left;
            public TreeNode right;
            public  TreeNode(){}

            public TreeNode(int data){
                this.val = data;
                this.left=null;
                this.right=null;
            }

            public TreeNode(int data, TreeNode left, TreeNode right){
                this.val = data;
                this.left = left;
                this.right =right;
            }
        }

        public static void preorderTraversal(TreeNode root){
            if(root is null) {
                return;
            }


            Console.WriteLine("Visiting "+root.val+" in preorder");
            preorderTraversal(root.left);
            preorderTraversal(root.right);
        }

        public static void inorderTraversal(TreeNode root){
            if(root is null) {
                return;
            }


            inorderTraversal(root.left);
            Console.WriteLine("Visiting "+root.val+" in inorder");
            inorderTraversal(root.right);
        }

        public static void postorderTraversal(TreeNode root){
            if(root is null) {
                return;
            }


            postorderTraversal(root.left);
            postorderTraversal(root.right);
            Console.WriteLine("Visiting "+root.val+" in postorder");
        }

        public static void ulerTraversal(TreeNode root){
            if(root is null) {
                return;
            }

            Console.WriteLine("Visiting "+root.val+" first time");
            ulerTraversal(root.left);
            Console.WriteLine("Visiting "+root.val+" second time");
            ulerTraversal(root.right);
            Console.WriteLine("Visiting "+root.val+" third time");
        }        
    }
}