using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Solution{
    static void Main(string[] args){
        int T = Convert.ToInt32(Console.ReadLine());
        int[] inputs = new int[T];
        for(int i = 0; i < inputs.Length; i++){
            inputs[i] = Convert.ToInt32(Console.ReadLine());
        }
        FindDigits(inputs);
        Console.ReadLine();
    }
    
    private static void FindDigits(int[] inputs){
        for(int i = 0; i < inputs.Length; i++){
            int count = 0;
            int n = inputs[i];
            int temp = 0;
            while(n != 0){
                temp = n % 10;
                n /= 10;
                if(temp != 0 && inputs[i] % temp ==0)
                    count += 1;
            }
            
            Console.WriteLine(count);
        }
    }
}