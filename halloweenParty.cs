using System;

namespace HalloweenParty{
    class Program{
        static void Main(string[] args){
            for(int t = int.Parse(Console.ReadLine()); t > 0; t--){
                long n = long.Parse(Console.ReadLine());
                Console.WriteLine(n / 2 * (n - n / 2));
            }
        }
    }
}