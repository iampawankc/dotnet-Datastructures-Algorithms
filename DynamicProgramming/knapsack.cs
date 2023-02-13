using System;

namespace Knapsack
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     //Jan 8, 2023 recording and Jan 12 recording
        //     //Problem: Find the max profit

        //     int[] cost = { 1, 4, 5, 7 };
        //     int[] wt = { 1, 3, 4, 5 };
        //     int cap = 8;   

        //     int result = knapsack(cost, wt, cap, cost.Length);
        //     Console.WriteLine(result);
        // }
        
        public static int knapsack(int[] cost, int[] wt, int cap,  int n){
            //Base case
            if(n==0 || cap==0) return 0;

            //Everytime I have 2 choices
            int maxprofit=0;
            //If I pick, but before picking I also have to check weather I can pick or not
            if(wt[n-1]<=cap){
                int c1=cost[n-1]+knapsack(cost, wt, (cap-wt[n-1]), n-1); //Picking the element
                int c2=0+knapsack(cost, wt, cap, n-1); //Not picking any element

                maxprofit=Math.Max(c1,c2); //Java version, check C# version
            }
            else
            {
                //In this case, I have jusy one option to not pick
                maxprofit=0+knapsack(cost, wt, cap, n-1);
            }
            return maxprofit;
        }
    }
}