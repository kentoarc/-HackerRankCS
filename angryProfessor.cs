using System;
using System.Collections;
using System.Collections.Generic;

class TEST{
    static void Main(){
        Sol mySol = new Sol();
        mySol.Solve();
    }
}

class Sol{
    public void Solve(){
        for(; T > 0; T--){
            var d = ria();
            int N = d[0];
            int K = d[1];
            int[] A = ria();
            int cnt = 0;
            for(int i = 0; i < N; i++){
                if(A[i] <= 0)
                    cnt++;
            }
            Console.WriteLine(cnt >= K? "NO" : "YES");
        }
    }
    int T;
    
    public Sol(){
        T = ri();
    }
    
    static String rs(){return Console.ReadLine();}
    static int ri(){return int.Parse(Console.ReadLine());}
    static long rl(){return long.Parse(Console.ReadLine());}
    static double rd(){return double.Parse(Console.ReadLine());}
    static String[] rsa(){return Console.ReadLine().Split(' ');}
    static int[] ria(){return Array.ConvertAll(Console.ReadLine().Split(' '), e => int.Parse(e));}
    static long[] rla(){return Array.ConvertAll(Console.ReadLine().Split(' '), e => long.Parse(e));}
    static double[] rda(){return Array.ConvertAll(Console.ReadLine().Split(' '), e => double.Parse(e));}
}