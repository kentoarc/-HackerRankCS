using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static int[] utopValue = new int[60];
    static int Utopian(int cycle){
        if(utopValue[cycle] != 0)
            return utopValue[cycle];
        else{
            if(cycle % 2 == 1){
                int temp = 2 * Utopian(cycle - 1);
                utopValue[cycle] = temp;
                return temp;
            }
            else{
                int temp = 1 + Utopian(cycle - 1);
                utopValue[cycle] = temp;
                return temp;
            }
        }
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string result = "";
        utopValue[0] = 1;
        string strOfTestcase = Console.ReadLine();
        
        int numOfTest = Convert.ToInt16(strOfTestcase);
        for(int i = 0; i < numOfTest; i++){
            int cycle = Convert.ToInt16(Console.ReadLine());
            result += Utopian(cycle).ToString() + "\n";
        }
        Console.WriteLine(result.Substring(0, result.Length - 1));
    }
}