using System;
using System.Collections.Generic;
using System.IO;
class Solution {
/*
 * Complete the function below.
 */
    static int maxXor(int l, int r) {
        int max = int.MinValue;
        for(int i = l; i <= r; i++){
            for(int j = i; j <= r; j++){
                max = Math.Max(max , i ^ j);
            }
        }
        return max;
    }

    static void Main(String[] args) {
        int res;
        int _l;
        _l = Convert.ToInt32(Console.ReadLine());
        
        int _r;
        _r = Convert.ToInt32(Console.ReadLine());
        
        res = maxXor(_l, _r);
        Console.WriteLine(res);
    }
}