using System;

namespace HouseRobber
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     //Jan 14, 2023 recording 
        //     // https://leetcode.com/problems/house-robber/
        //     //Problem: 
        //     int[] house = [10,20,30,40,50,60]
        //     int n=6
        //     int maxSteal = HouseRobber(house, n);

        // }
        
        public static int HouseRobber(int[] house, int n){
            //Here we are following bottomup approach
            //Base case
            if(n<=0) return 0;

            //Everytime I have 2 choices
            int maxprofit=0;

            //If I pick, but before picking I also have to check weather I can pick or not
            int c1=house[n-1]+HouseRobber(house, n-2); //Picking the element
            int c2=0+HouseRobber(house,n-1); //Not picking any element

            maxprofit=Math.Max(c1,c2); //Java version, check C# version
            
            return maxprofit;
        }

        public static int HouseRobberCircular(int[] house, int n){
            //Here we are following bottomup approach
            //Base case
            if(n<=0) return 0;

            //Everytime I have 2 choices
            int maxprofit=0;

            //If I pick, but before picking I also have to check weather I can pick or not
            int c1=house[n-1]+HouseRobber(house, n-2); //Picking the element
            int c2=0+HouseRobber(house,n-1); //Not picking any element

            maxprofit=Math.Max(c1,c2); //Java version, check C# version
            
            return maxprofit;
        }

    }
}