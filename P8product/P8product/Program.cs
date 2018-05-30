using System;
using System.Numerics;

namespace P8product
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger product = 1;
            BigInteger max = 0;
            int howmany = 13;
            string[] astr = new string[howmany];
            int[] a = new int[howmany];
            BigInteger answer = 5;

            string longnumber = System.IO.File.ReadAllText("number.txt");

            for (int j = 0; j < (1000-howmany); j++) {
                product=1;
                for (int i = 0; i < howmany; i++)
                {
                    astr[i] = longnumber.Substring(j+i, 1);
                    a[i] = Convert.ToInt32(astr[i]);
                    product = product * a[i];
                }
                //Console.WriteLine(j + " " + product);
                if (product > answer)
                {
                    answer = product;
                 }
            }   
            //Console.WriteLine(longnumber);
            Console.WriteLine(answer + " is the maximum product " ); //23514624000
            Console.ReadKey();
        }
    }
}
