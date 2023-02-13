using System;

namespace ClimbingStairs
{
    class Program2
    {
        // static void Main(string[] args)
        // {
        //     //Jan 7, 2023 recording
        //     //Problem: Find the number of possible ...
        //     //A person can maximum clims 1 or 2 steps in a shot.
            
        //     int n=5;
        //     int paths=totalPath(n);
        //     Console.WriteLine("Total possible paths "+paths);
        //     printPaths(n,"");
        // }

        //Expectation: total number of paths from n->0
        public static int totalPath(int n){
            //base case
            if(n==0){
                //Here I have found path
                return 1;
            }else if(n<0)
            {
                //No further paths available
                return 0;
            }
            int p1=totalPath(n-1); //This is basically I am asking recursion to tell me total number of path from(n-1)th stair to 0th stair
            int p2=totalPath(n-2); //This is basically I am asking recursion to tell me total number of path from(n-2)th stair to 0th stair

            int totalPaths=p1+p2;
            return totalPaths;
        } 

        public static void printPaths(int n,string path){
            //base case
            if(n==0){
                //Here I have found path
                Console.WriteLine(path);
                return;
            }else if(n<0)
            {
                //No further paths available
                return;
            }
            printPaths(n-1, path+"j1 ");
            printPaths(n-2, path+"j2 ");
        }
    }
}