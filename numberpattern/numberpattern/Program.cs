using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, n,k=1;

            Console.Write("Input number of rows : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (x = 1; x <= n; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("  "+k++);
                }
                Console.WriteLine();
            }
        }
    }
}
