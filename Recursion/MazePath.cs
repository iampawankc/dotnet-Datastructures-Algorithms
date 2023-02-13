using System;

namespace MazePath
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     //Jan 7, 2023 recording
        //     //Problem: Find all the possible paths to travel a n*n matrix, the person can move in 3 ways: a)Right horizontal, 
        //     //b)Down vertical, c)Down horizontal. 
        //     //r = rows, c=columns, v=vertical, d=diagonal, h=horizontal

        //     int r=2;
        //     int c=2;
        //     int paths=countMazePath(r,c);
        //     Console.WriteLine("Total possible paths "+paths);
        //     printPaths(r,c,"");
        // }

        //Expectation: 
        public static int countMazePath(int r, int c){
            //base case
            if(r==0 && c==0){
                return 1;
            }else if(r<0 || c<0){
                return 0;
            }

            int v=countMazePath(r-1, c);
            int h=countMazePath(r, c-1);
            int d=countMazePath(r-1, c-1);

            return (h+v+d);
        } 

        public static void printPaths(int r,int c,string path){
            //base case
            if(r==0 && c==0){
                Console.WriteLine(path);
                return;
            }else if(r<0 || c<0){
                return;
            }
            printPaths(r-1, c, path+"v ");
            printPaths(r, c-1, path+"h ");
            printPaths(r-1, c-1, path+"d ");
        }
    }
}