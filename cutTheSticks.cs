using System;
using System.Collections.Generic;
using System.IO;
class Solution{
    static void Main(String[] args){
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');
        int[] y = new int[n];
        for (int i = 0; i < n; i++){
            y[i] = int.Parse(s[i]);
        }
        Array.Sort(y);
        int count = y.Length;
        for(int i = 0; i < n; i++){
            int j = i;
            int m = 0;
            while (j < n && y[i] == y[j]){
                m++; 
                j++;
            }
            Console.WriteLine("{0}", count);
            count -= m;
            i = j - 1;
        }             
    }
}
;