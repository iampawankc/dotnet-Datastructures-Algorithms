using System;
using System.Collections.Generic;

namespace Sets{

    public class sets{
        public static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(10);
            hs.Add(20);
            hs.Add(30);
            hs.Add(30);

            //We can see the entire hashmap
            foreach(int s in hs){
                Console.WriteLine(s);
            }

            Console.WriteLine("Length of hashset "+hs.Count);

            Console.WriteLine("Check if element exists "+hs.Contains(50));

            //Given an array, figure out weathwe it contains duplicate elements or not?
            int[] intarr= new int[10,20,30,30,40,50];
        }

        public static bool containsDuplicate(int[] arr){
            
        }
    }
}


