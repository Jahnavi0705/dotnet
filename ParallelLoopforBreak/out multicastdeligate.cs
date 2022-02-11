using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelLoopforBreak
{
    internal class out_multicastdeligate
    {
        public static void Method1(out int number)
        {
            number = 1;

        }
        public static void Method2(out int number)
        {
            number = 2;

        }

        public delegate void SampleDelegate(out int Integer);
        static void Main5(string[] args)
        {
            SampleDelegate del = new SampleDelegate(Method1);
            del+= Method2;
            int ValuefromOutput = -1;
            del(out ValuefromOutput);
            Console.WriteLine(ValuefromOutput);
        }
    }
}
