using System;
using System.Globalization;

class Solution{
    static void Main(String[] args){
        string s = Console.ReadLine();
        for(int i = 0; i < Convert.ToInt32(s); i++){
            int steps = Convert.ToInt32(Console.ReadLine());
            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            
            int smaller = firstNum > secondNum ? secondNum : firstNum;
            int difference = Math.Abs(firstNum - secondNum);
            
            steps--;
            int current = smaller * steps;
            
            if(difference == 0){
                Console.WriteLine(current);
            }
            else{
                String result = current.ToString(CultureInfo.InvariantCulture);
                for(int j = 0; j < steps; j++){
                    current += difference;
                    result = result + " " + current.ToString(CultureInfo.InvariantCulture);
                }
                Console.WriteLine(result);
            }
        }
    }
}