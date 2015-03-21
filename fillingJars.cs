using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        string[] parts = Console.ReadLine().Split(' ');
        
        int N = Convert.ToInt32(parts[0]);
        int M = Convert.ToInt32(parts[1]);
        
        Int64 rez = 0;
        
        for(int i = 0; i < M; i++){
            parts = Console.ReadLine().Split(' ');
            
            int a = Convert.ToInt32(parts[0]);
            int b = Convert.ToInt32(parts[1]);
            int k = Convert.ToInt32(parts[2]);
            
            rez += (b - a + 1) * (Int64)k;
        }
        
        rez /= N;
        
        Console.WriteLine(rez);
    }
}