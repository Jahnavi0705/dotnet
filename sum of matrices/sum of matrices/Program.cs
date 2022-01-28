using System;

namespace sum_of_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] b = new int[2, 2] { { 2, 4 }, { 6, 8 } };
            int[,] sum = new int[2, 2];
            Console.WriteLine("Matrix a:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix b:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("Sum of two matrices is: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
