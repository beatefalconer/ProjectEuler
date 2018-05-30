using System;


namespace P6squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum_o_sq = 0;
            int sq_o_sum = 0;
            int sum = 0;
            int difference = 0;
            int max = 100;

            for (int i = 1; i <= max; i++)
            {
                sum_o_sq = sum_o_sq + (i*i);
                sum = sum + i;
            }
            sq_o_sum = sum * sum;
            difference = sq_o_sum - sum_o_sq;

            //Console.WriteLine(sum);
            //Console.WriteLine(sq_o_sum);
            //Console.WriteLine(sum_o_sq);
            Console.WriteLine(difference); //25164150
            Console.ReadKey();
        }
    }
}
