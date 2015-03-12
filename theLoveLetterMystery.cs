using System;

class Solution {
    public static void Main() {
        int t = int.Parse(Console.ReadLine());
        while( t > 0){
            string s = Console.ReadLine().Trim();
            int i = 0;
            int j = s.Length - 1;
            int totalOperation = 0;
            while( i < j){
                int a = (int)s[i];
                int b = (int)s[j];
                totalOperation += Math.Abs(a-b);
                i++;
                j--;
            }
            Console.WriteLine(totalOperation);
            t--;
        }
    }
}