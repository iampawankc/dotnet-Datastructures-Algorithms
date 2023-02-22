using System;
using System.Collections.Generic;

namespace Maps{

    public class Maps{
        // public static void Main(string[] args)
        // {
        //     // Hashmap are not avaiable in C#, use Dictionaries instead
        //     Dictionary<string,int> dict = new Dictionary<string, int>();

        //     dict.Add("ndia", 100000);
        //     dict.Add("UK", 1000);
        //     dict.Add("China", 10000000);

        //     foreach(var kvp in dict){
        //         Console.WriteLine(kvp.Key+" -> "+kvp.Value);
        //     }

        //     Console.WriteLine(dict.ContainsKey("India"));
        //     Console.WriteLine(dict.ContainsValue(1000));

        //     int[] intarr= new int[] {10,20,30,30,40,50,60};
        //     //GetFrequency(intarr);
            
        //     int[] intarr2= new int[] {10,20,40,50};
        //     //GetUniqueCommonElements(intarr, intarr2);
        //     GetCommomElements(intarr, intarr2);
        // }

        public static void GetFrequency(int[] arr){
            //Print number of times a element is present in array
            Dictionary<int, int> counter = new Dictionary<int, int>();
            foreach(int i in arr){
                if(counter.ContainsKey(i)){
                    //Element already exists, get the value and increment 
                     int val=0;
                     counter.TryGetValue(i,out val);
                     counter[i]= val+1;
                }
                else{
                    //Element encountered first time, add to dict
                    counter.Add(i,1);
                }
            }

            foreach(var kvp in counter){
                Console.WriteLine(kvp.Key+" -> "+kvp.Value);
            }
        }

        public static void GetUniqueCommonElements(int[] intArr1, int[] intArr2){
            //To figure out unique elements, use sets
            HashSet<int> uniqueInt1 = new HashSet<int>(intArr1);

            foreach(int i in intArr2){
                if(uniqueInt1.Contains(i)){
                    Console.WriteLine("Unique "+i);
                    uniqueInt1.Remove(i); //Removing to handle duplicacy
                }
            }
        }

        public static void GetCommomElements(int[] arr1, int[] arr2){
            
        }
    }
}