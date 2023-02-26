using System;
using System.Collections.Generic;

namespace StackQueue
{
    public class StackQueue
    {
        // public static void Main(string[] args)
        // {
        //     // string exprn="((a+b)+(c+d)*((b-x)))"; 
        //     // bracketBalance(exprn);    
        //     int[] intArr = new int[] {2,5,9,3,1,12,6,8,7};
        //     nextGreaterElementLeft(intArr);       
        // }   

        public static void bracketBalance(string exprn){
            //Find the duplicate bracket OR balance the bracket
            Console.WriteLine(exprn);
            Stack<char> stk = new Stack<char>();
            int found=0;
            foreach (char ch in exprn)
            {
                if(ch != ')'){
                    //Insert elements to stack till you encounter closing bracket ')'
                    stk.Push(ch);
                }
                else
                {
                    //If opening bracket found, then it is a duplicate. Report and exit.
                    if(stk.Peek() == '('){
                        Console.WriteLine("Duplicate bracket found");
                        found=1;
                        break;
                    }

                    //Iterate and pop all elements till you ecounter open bracket '(' and pop open bracket too
                    for(int i=0; i<stk.Count; i++){
                        if(stk.Peek()!='('){
                            stk.Pop();
                        }
                        else{
                            stk.Pop();
                            break;
                        }
                    }
                    //Continue the process
                }
            }
            if(found == 0){
                Console.WriteLine("No duplicate bracket found");
            }
        }

        public static void nextGreaterElementLeft(int[] inrArr){
            foreach(int i in inrArr){
                Console.Write(i+" ");
            }
            foreach(int i in inrArr){
                
            }
            //To complete
        }    

        public static void queues(){
            Queue<int> numbers = new Queue<int>();        
            numbers.Enqueue(10);
            numbers.Enqueue(20);

        }
    }
}