using System;

namespace Problem3PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 13195;
            long number = 600851475143;
            Console.WriteLine("The prime factors of your number are ");
            int max = (int)Math.Ceiling(Math.Sqrt(number));
            //Console.WriteLine(max);
            for (int i = 2; i < max; i++)
            {
                if (number % i == 0)
                {
                    int factor = i;
                    if (factor % i == 0)
                    {
                        number = number / factor;
                        Console.WriteLine(factor);
                    }
                    
                }
            }
            Console.ReadKey(); //6857

        }
    }
}
