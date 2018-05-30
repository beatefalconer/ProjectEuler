using System;


namespace P14collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 1000000;
            int startnum = 13;
            int answer = 0;
            int startanswer = 0;
            int count = 0;
            for (startnum = 13; startnum <= max; startnum++)
            {
                long num = startnum;
                count = 1;
                while (num > 1)
                {
                    if (num % 2 == 0)
                    {num = num / 2;}
                    else
                    {num = (3 * num) + 1;}
                    count++;
                }
                if (count > answer)
                {
                    startanswer = startnum;
                    answer = count;
                }
            }

            Console.WriteLine("starting number " + (startanswer));
            Console.WriteLine("length of chain " + (answer));
            Console.ReadKey();
            //starting number 837799
            //length of chain 525
        }
    }
}
