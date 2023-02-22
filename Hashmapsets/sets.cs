using System;
using System.Collections.Generic;

namespace Sets{

    public class sets{
        // public static void Main(string[] args)
        // {
        //     //Hashset is a collection of only unique elements, the order of elements 
        //     //within the hashset cannot be controlled. when inserting, If elements already exists, 
        //     // it gets overritten
        //     HashSet<int> hs = new HashSet<int>();
        //     hs.Add(10);
        //     hs.Add(20);
        //     hs.Add(30);
        //     hs.Add(30);

        //     //We can see the entire hashmap
        //     foreach(int s in hs){
        //         Console.WriteLine(s);
        //     }

        //     Console.WriteLine("Length of hashset "+hs.Count);
        //     Console.WriteLine("Check if element exists "+hs.Contains(50));

        //     //Given an array, figure out weathwe it contains duplicate elements or not?
        //     int[] intarr= new int[] {10,20,30,30,40,50};
        //     bool res = containsDuplicate(intarr);
        //     Console.WriteLine("Array contains duplicate element: "+res);
        // }

        public static bool containsDuplicate(int[] arr){
            HashSet<int> newhs = new HashSet<int>(arr); 
            if(newhs.Count == arr.Length) return true;
            else return false;
        }
    }
}


