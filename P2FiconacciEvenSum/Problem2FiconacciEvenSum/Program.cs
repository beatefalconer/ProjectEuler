using System;
using System.Text;
using System.IO;


namespace Problem2FiconacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 400;

            //Int32[] Fib = new Int32[size];
            double[] Fib = new double[size];
            Fib[0] = 1;
            Fib[1] = 2;
            //Int32 sum = 2; // only even numbers
            double sum = 2; // only even numbers
            for (int i = 2; i < size; i++)
            {
                Fib[i] = Fib[i - 1] + Fib[i - 2];
                if (Fib[i] < 4000000)
                {
                    if (((Fib[i]) % 2) == 0) {
                        Console.WriteLine(Fib[i]);
                        sum = sum + Fib[i];
                        Console.WriteLine(sum);
                    }
                }
                else
                {
                    //end loop;
                }
            }

            Console.WriteLine("The sum of all even Fibonacci numbers under 4M is: ");
            Console.WriteLine(sum); //4613732
            Console.ReadKey();
        }
    }
}
