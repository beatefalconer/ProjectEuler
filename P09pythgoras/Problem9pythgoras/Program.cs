using System;

namespace Problem9pythgoras
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int c = 3; c < 998; c++)
            {
                for (int b = 2; b < 998; b++)
                {
                    for (int a = 1; a < 998; a++)
                    {
                        int pythProduct = (a * a) + (b * b);
                        if (pythProduct == (c * c) && (a<b) && (b<c) && (a+b+c==1000))
                        {
                            Console.WriteLine("success");
                            Console.WriteLine(a + " " + b + " " + c + " " + a*b*c);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
