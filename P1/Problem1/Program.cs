using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000;
            int sum = 0;
            Console.WriteLine("The factors are: ");
            for (int i= 1; i<max; i++)
            {
                if (i % 3 ==0 || i % 5 == 0)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                    
                }
            }
            Console.WriteLine("The sum is: ");
            Console.WriteLine(sum); //233168
            Console.ReadKey();
        }
    }
}
