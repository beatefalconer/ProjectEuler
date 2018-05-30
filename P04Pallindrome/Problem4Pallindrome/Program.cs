using System;

namespace Problem4Pallindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pallindrome = "";
            int number1 = 999;
            int number2 = 999;
            int[] answer = new int[3];
            //int[] temp = new int[3];
            for (number1 = 999; number1 > 900; number1--) {
                for (number2 = 999; number2 > 900; number2--)
                {
                    int product = number1 * number2;
                    string productstring = product.ToString();
                    char[] inputarray = productstring.ToCharArray();
                    Array.Reverse(inputarray);
                    string output = new string(inputarray);
                    if (output == productstring)
                    {
                        pallindrome = productstring;
                        answer[0] = number1;
                        answer[1] = number2;
                        answer[2] = product;
                        Console.WriteLine(answer[0] + " " + answer[1] + " " + answer[2]);
                    }
                }
            }
            //Console.WriteLine(number1 + " " + number2);
            //Console.WriteLine(pallindrome); //    
            //Console.WriteLine(answer[0] + " " + answer[1] + " " + answer[2]);
            Console.ReadKey();
        }
    }
}
