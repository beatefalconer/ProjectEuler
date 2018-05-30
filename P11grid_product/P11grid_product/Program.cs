using System;
using System.IO;
//using System.Numerics;

namespace P11grid_product
{
    class Program
    {
        static void Main(string[] args)
        {
            long product = 0;
            long prod_horz = 0;
            long prod_vert = 0;
            long prod_diag = 0;
            long prod_diagr = 0;
            int max = 20;
            string[] gridline = new string[max];
            int x = 0;
            int y = 0;
            int howmany = 4;
            string[] numberstr = new string[max];
            int[,] numbers = new int[max,max];
            string filename = "grid.txt";

            //string longnumber = File.ReadAllText(filename);
            //string longnumber2 = File.ReadLines(filename);

            gridline = File.ReadAllLines(filename); // reads each line into an element of gridline[]

            //for (int b = 0; b < max; b++)
            //{
            //    Console.WriteLine(gridline[b]);
            //}

            int i = 0;
            while (i<max)
            {
                numberstr = gridline[i].Split();
                //Console.WriteLine("{0} numbers in row: ", numberstr.Length);
                for (int j = 0; j < max; j++)
                {
                    numbers[i, j] = Convert.ToInt32(numberstr[j]);
                    //Console.WriteLine(numbers[i, j]);
                }
                i++;
            }

            //Console.WriteLine(numberstr[19]);

            for (x = 0; x < (max - howmany + 1); x++)
            {
                //Console.WriteLine(x);
                for (y = 0; y < (max); y++)
                {
                    //Console.WriteLine(y);
                    prod_horz = numbers[x, y] * numbers[x + 1, y] * numbers[x + 2, y] * numbers[x + 3, y];
                    if (prod_horz > product)
                    {
                        product = prod_horz;
                        //Console.WriteLine(prod_horz + " " + x + " " + y);
                        //Console.WriteLine(numbers[x, y] + " " + numbers[x + 1, y] + " " + numbers[x + 2, y] + " " + numbers[x + 3, y]);
                    }
                }
            }
            for (x = 0; x < (max); x++)
            {
                //Console.WriteLine(x);
                for (y = 0; y < (max - howmany + 1); y++)
                {
                    prod_vert = numbers[x, y] * numbers[x, y + 1] * numbers[x, y + 2] * numbers[x, y + 3];
                    
                    if (prod_vert > product)
                    {
                        product = prod_vert;
                        //Console.WriteLine(prod_vert + " " + x + " " + y);
                        //Console.WriteLine(numbers[x, y] + " " + numbers[x, y + 1] + " " + numbers[x, y + 2] + " " + numbers[x, y + 3]);
                    }
                }
            }
            for (x = 0; x < (max - howmany + 1); x++)
            {
                //Console.WriteLine(x);
                for (y = 0; y < (max - howmany + 1); y++)
                {
                    prod_diag = numbers[x, y] * numbers[x + 1, y + 1] * numbers[x + 2, y + 2] * numbers[x + 3, y + 3];
                    if (prod_diag > product)
                    {
                        product = prod_diag;
                        //Console.WriteLine(prod_diag + " " + x + " " + y);
                        //Console.WriteLine(numbers[x, y] + " " + numbers[x + 1, y + 1] + " " + numbers[x + 2, y + 2] + " " + numbers[x + 3, y + 3]);
                    }
                    //Console.WriteLine(prod_diag + " " + x + " " + y);
                }
            }
            for (x = howmany-1; x < max ; x++)
            {
                //Console.WriteLine(x);
                for (y = 0; y < (max-howmany+1) ; y++)
                {
                    prod_diagr = numbers[x, y] * numbers[x - 1, y + 1] * numbers[x - 2, y + 2] * numbers[x - 3, y + 3];
                    if (prod_diagr > product)
                    {
                        product = prod_diagr;
                        //Console.WriteLine(prod_diagr + " " + x + " " + y);
                        //Console.WriteLine(numbers[x, y] + " " + numbers[x - 1, y + 1] + " " + numbers[x - 2, y + 2] + " " + numbers[x - 3, y + 3]);
                    }
                    //Console.WriteLine(prod_diagr + " " + x + " " + y);
                }
            }

            Console.WriteLine("the largest product is ");
            Console.WriteLine(product); //
            Console.ReadKey();          //70600674
        }
    }
}
