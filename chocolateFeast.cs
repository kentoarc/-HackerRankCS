using System; 
using System.Collections.Generic; 
using System.IO;
using System.Linq;
using System.Text;

class Solution {
    private static bool testMode = false;

    static void Main(String[] args) {
        int T = int.Parse(Console.ReadLine());
        
        for (int x = 0; x < T; x++){
            string[] d = (Console.ReadLine()).Split(' ');
            int N = int.Parse(d[0]);
            int C = int.Parse(d[1]);
            int M = int.Parse(d[2]);
            
            int b = N / C;
            if (b < M)
                Console.WriteLine(b);
            else{
                int totalWrappers = b;
                int additionalChocolates = 0;
                while((b + additionalChocolates) >= M)
                    GetAdditionalChocolates(M, ref b, ref additionalChocolates);
                
                Console.WriteLine(totalWrappers + additionalChocolates);
            }
        }
        
        if(testMode)
            Console.ReadLine();
  }
    
    private static void GetAdditionalChocolates(int M, ref int leftOver, ref int additional){
        while((leftOver + additional) >= M){
            additional++;
            leftOver -= M;
        }
    }
}