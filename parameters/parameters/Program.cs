using System;

namespace parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample(6);
            Sample(6, 7);
            Sample(6, 7, 8);
        }
        public static void Sample(int x, int y = 10, int z = 20)
        {
            Console.WriteLine("{0},{1},{2}", x, y, z);
        }
    }
}
