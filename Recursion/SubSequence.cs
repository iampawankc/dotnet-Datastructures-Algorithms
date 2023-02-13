using System;

namespace SubSequence
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     //Jan 7, 2023 recording
        //     //Hint: Use recursions to when question is similar to find all possiblities.

        //     Printsub("123",0,"");
            
        // }

        public static void Printsub(string str, int idx, string sfs){ //sfs=string so far
            //Base case
            if(idx==str.Length){
                Console.WriteLine(sfs);
            }

            char ch = str[idx];
            Printsub(str, idx+1, sfs+ch);

            Printsub(str, idx+1, sfs+"-");
        }
    }
}