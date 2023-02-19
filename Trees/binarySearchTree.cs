using System;
using System.Collections.Generic;

namespace Trees
{
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

    public class BinarySearchTree
    {
        //At any point of time left of tree is always lower than right of tree
        //Left to right in ascending order for any node of the tree

        // public static void Main(string[] args)
        // {
        //     TreeNode rnode = new TreeNode{
        //         val=50, left=new TreeNode{val=45,right=null,left=null }, right= new TreeNode{val=60,right=null,left= null}
        //     };
        //     TreeNode lnode = new TreeNode{
        //         val=30, left=new TreeNode{val=25,right=null,left=null }, right= new TreeNode{val=35,right=null,left=null }
        //     };
        //     TreeNode tree = new TreeNode{
        //         val=40, left=lnode, right= rnode
        //     };

        //     // bool res = searchBST(tree, 601);
        //     // if (res==true) Console.WriteLine("Node available");
        //     // else Console.WriteLine("Node not available");

        //     TreeNode node = new TreeNode{ val=55, left=null, right=null};
        // }

        public static bool searchBST(TreeNode root, int element){
            //Base case
            if(root==null) return false;

            if(root.val==element) return true;
            else if(element < root.val) return searchBST(root.left, element);
            else return searchBST(root.right, element);
          }

        public static void addNodeBST(TreeNode root, int element){
            //Base case
            //Adding node can only be at leaf nodes
            // if(root==null) return null;

            // if(root.val<element) return addNodeBST(root.right);
            // else return addNodeBST(root.left);
        }
    }
}