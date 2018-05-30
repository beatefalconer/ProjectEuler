using System;
using System.Numerics ;

namespace P20Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            BigInteger sum = 0;
            BigInteger factorial = 1;
            for (int i = 1; i <= max; i++)
            {
                factorial = factorial * i;
            }
            BigInteger finalfactorial = factorial;
            
            while (factorial != 0)  //https://stackoverflow.com/questions/478968/sum-of-digits-in-c-sharp
            {
                sum += factorial % 10;
                factorial /= 10;
            }
            Console.WriteLine(finalfactorial); //93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000
            Console.WriteLine("Sum of digits of the " + max + "th factorial" + sum); //648
            Console.ReadKey();
        }
    }
}
