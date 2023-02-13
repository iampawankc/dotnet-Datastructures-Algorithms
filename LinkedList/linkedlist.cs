using System;

namespace Linkedlist
{
    public class Program
    {
        // public static void Main(string[] args)
        // {
        //     //Feb 4 & 5 2023 recording 
        //     //Linkedlist are created to solve/patch memory gap created by arrays(continous memory locations) 
        //     //Heirarchical data structure
        //     //1.Binary tree, 2.Binary searchtree, 3. Generic tree
        //     //Linear linked list
        //     //1.Linked list, 2.Stack, 3.Queues

        //     node head = CreateLinkedList();
        //     DisplayLinkedList(head);

        //     //TODO add new node at
        //     // addFirst()
        //     // addLast()
        //     // addRandom()
        //     // removeFirstNode()
        //     // removeLastNode()
        //     // removeRandomNode()

        // }
        public static node CreateLinkedList(){
            Console.WriteLine("Head value??");
            int x = int.Parse(Console.ReadLine());
            if(x==-1) return null;
            
            node head = new node(x);
            node pre = head;

            while (true)
            {
                Console.WriteLine("Value of new node");
                int temp = int.Parse(Console.ReadLine());
                if(temp == -1){ //Sign of linked list completion
                    break;
                }

                node curr = new node(temp);
                pre.next = curr;
                pre = curr;
            }
            Console.WriteLine("Program completed!!");
            return head;
        }

        public static void DisplayLinkedList(node head){
            node curr = head;
            while(curr != null){
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }

        public static void checkPalindrome(node head){

        }

        public class node
        {
            public int data;
            public node next;
            
            public node(){}
            public node(int data){
                this.data = data;
                this.next = null;
            }
            public node(int data, node next){
                this.data = data;
                this.next = next;
            }
        }
    }
}