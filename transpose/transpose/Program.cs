using System;

namespace transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, row, col;
            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];

            Console.WriteLine("Enter no of rows and columns: ");
            Console.WriteLine("rows: ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("columns: ");
            col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter elements in matrix: ");
            for(i=0; i<row;i++)
            {
                for(j=0;j<col;j++)
                {
                    Console.WriteLine();
                    a[i, j] = Convert.ToInt32(Console.ReadLine());


                }
            }

            Console.WriteLine("Matrix is: ");
            for(i=0;i<row;i++)
            {
                Console.WriteLine();
                for (j = 0; j < col; j++)
                    Console.Write(a[i, j]+"\t");
            }
            for(i=0;i<row;i++)
            {
                for(j=0;j<col;j++)
                {
                    b[j, i] = a[i, j];
                }
            }
            Console.WriteLine("Transpose of a matrix is: ");
            for(i=0;i<col;i++)
            {
                Console.WriteLine();
                for(j=0;j<row;j++)
                {
                    Console.Write(b[i, j]+"\t");
                }
            }
            Console.WriteLine();


        }
    }
}
