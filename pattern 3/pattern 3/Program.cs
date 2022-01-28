using System;

namespace pattern_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 1; x <= 4; x++)
            {
                for (y = 1; y <= 6; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
