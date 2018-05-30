using System;

namespace P10Primes
{
    class Program
    {
        static bool isPrime(int number)
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
            

            long sum = 0;
            int max = 2000000;

            for (int i = 2; i < max; i++)
            {
                if (isPrime(i)) {
                    sum = sum + i;
                 }
            }
            Console.WriteLine(sum); //142913828922
            Console.ReadKey();
        }
    }
}
