using System;

namespace pattern_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 6; x >= 1; x--)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
