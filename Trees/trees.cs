using System;
using System.Collections.Generic;

namespace Trees
{
    public class Trees
    {
        // public static void Main(string[] args)
        // {
        //     //Class of Sunday, Feb 12, Feb 18
        //     //Concepts: Binary tree, Root node, leaf node, left sub tree, right sub tree, 
        //     //Traversal(Preorder,Inorder, Postorder, Levelorder)
        //     //Binary tree has atmost 2 children

        //     TreeNode lnode = new TreeNode{
        //         val=9, left=new TreeNode{val=3,right=null,left=null }, right= new TreeNode{val=2,right=null,
        //         left=new TreeNode{ val=10, left=null, right=null } }
        //     };
        //     TreeNode rnode = new TreeNode{
        //         val=20, left=new TreeNode{val=15,right=null,left=null }, right= new TreeNode{val=79,right=null,left=null }
        //     };
        //     TreeNode tree = new TreeNode{
        //         val=3, left=lnode, right= rnode
        //     };


        //     //ulerTraversal(tree);
        //     //preorderTraversal(tree);
            
        //     // int res = sumAllNodes(tree);
        //     // Console.WriteLine("Sum of all nodes is "+res);

        //     // int res = MaxTree(tree);
        //     // Console.WriteLine("Max of all nodes is "+res);            

        //     // int res = MinTree(tree);
        //     // Console.WriteLine("Min of all nodes is "+res);    

        //     // TreeNode findNode = new TreeNode{
        //     //     val=99,right=null,left=null
        //     // };
        //     // bool res = searchTree(tree, findNode);
        //     // if(res==true){Console.WriteLine("Node exists");}
        //     // else{Console.WriteLine("Node does not exists");}

        //     // int count=0;
        //     // int res=binaryTreeHeight(tree,count);
        //     // Console.WriteLine("Height of the tree:"+res);

        //     int count=0;
        //     int res=DiameterOfBinaryTree(tree,count);
        //     Console.WriteLine("Width of the tree:"+res);
        // }

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

        public static int sumAllNodes(TreeNode root){
            if(root == null) return 0;

            return sumAllNodes(root.left)+sumAllNodes(root.right)+root.val;
        }

        public static int MinTree(TreeNode node){
            if(node == null) return int.MaxValue;

            return Math.Min(node.val, Math.Min(MinTree(node.left),MinTree(node.right)));
        }

        public static int MaxTree(TreeNode node){
            if(node == null) return int.MinValue;

            return(Math.Max(node.val, Math.Max(MaxTree(node.left),MaxTree(node.right ))));
        }

        public static bool searchTree(TreeNode root, TreeNode find){
            //Check weather node exists in a given tree and find its occurance times
            // if(root == null) return false;

            // if(root.val==find.val) return true;
            
            // searchTree(root.left, find);
            // if(root.val==find.val) return true;
            // searchTree(root.right, find);
            // if(root.val==find.val) return true;

            if(root == null) return false;
            if(root.val==find.val) return true;
            else return searchTree(root.left, find) ||  searchTree(root.right, find);
        }

        //public static bool searchTreeFrequency(TreeNode root, TreeNode find){
            //homework
            //Find the number of time node appears in searchtree
        //}

        public static int binaryTreeHeight(TreeNode root, int count){
            if(root == null) return 0;

            if(root.val!=null) count++;
            return Math.Max(binaryTreeHeight(root.left, count), binaryTreeHeight(root.right,count))+1;
        }

        // public static int DiameterOfBinaryTree(TreeNode root, int count){
        //     //Diameter if 
        //     //TODO
        //     //Homework, refer to recording Day Feb 18
        // }
    }
}