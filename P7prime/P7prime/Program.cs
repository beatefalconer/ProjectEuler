using System;

namespace P7prime
{
        class Program
    {
        static bool isPrime(int number) //https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int max = 200000;
            int prime = 1;
            int count = 0;
            int stop = 10001;

            for (int i = 2; i < max; i++)
            {
                if (isPrime(i))
                {
                    prime = i;
                    count = count + 1;
                    //Console.WriteLine(count + "th prime: " + i);
                }
                if (count == stop)
                {
                    max = count;
                }
            }

            
            Console.WriteLine(count + "th prime: " + prime); //104743
            Console.ReadKey();
        }
    }
}
