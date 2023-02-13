using System;

namespace TowerOfHanio
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     //Jan 7, 2023 recording
        //     //Move disks across source to destination using a single helper.
        //     //Conditions: Disks are of different sizes, smaller disk cannot sit on bigger disk
        //     //should not move more than 1 disk at a time.

        //     //Hint: Use recursions to when question is similar to find all possiblities.

        //     int n=5;
        //     toh(n,"T1", "T2", "T3");
        // }
        
        public static void toh(int n, string src, string help, string dest){
            //Base case
            if(n==0){
                return;
            }
            
            toh(n-1, src, dest, help);

            Console.WriteLine("Move "+n+"th disk from "+src+" to "+dest);

            toh(n-1, help, src, dest);
        }
    }
}