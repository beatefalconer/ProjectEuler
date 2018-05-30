using System;

namespace Problem5Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 20;
            int divisible = 0 ;
            for (int i = 10; i < 300000000; i++)
            {
                divisible = 0;
                for (int d = 0; d <max; d++)
                {
                    if (i % (d+1) == 0)
                    {
                        divisible = divisible + 1;
                    }
                }
                if (divisible == max)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
