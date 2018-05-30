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
            answer[0] = 0;
            answer[1] = 0;
            answer[2] = 0;
            int[] temp = new int[3];
            temp[0] = 0;
            temp[1] = 0;
            temp[2] = 0;
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
                        temp[0] = number1;
                        temp[1] = number2;
                        temp[2] = product;
                        //Console.WriteLine(temp[0] + " " + temp[1] + " " + temp[2]);
                        //Console.WriteLine(answer[2] + " " + temp[2]);
                        
                    }
                    if (answer[2] < temp[2])
                    {
                        answer[0] = temp[0];
                        answer[1] = temp[1];
                        answer[2] = temp[2];
                        //Console.WriteLine("answer " + answer[0] + " " + answer[1] + " " + answer[2]);
                    }
                    
                }
            }
            
            //Console.WriteLine(pallindrome); //    
            Console.WriteLine("final answer " + answer[0] + " " + answer[1] + " " + answer[2]);
            Console.ReadKey();
        }
    }
}
