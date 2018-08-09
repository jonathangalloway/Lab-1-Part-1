using System;

namespace ConsoleApp4
{
    public class Hello
    {
        static void Main()
             int number1 = 543;
        int number2 = 456;
        int? lastTotal = null;
        string answer = "False";
        if (number1.ToString().Length == number2.ToString().Length)  {
            for (int i = 0; i<number1.ToString().Length; i++)
                {
                    int newTotal = Int32.Parse(number1.ToString().Substring(i, 1))
                    if (lastTotal == null)  {
                        lastTotal = newTotal;
                    }
                    if (lastTotal == newTotal){
                        answer = "True";
                    }else{
                        answer = "False"; 
        }
    }
}
    Console.WriteLine(answer);    