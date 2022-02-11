using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelFor
{
    internal class Parallelforloopbreak
    {
        static void Main1(string[] args)
        {
            var BreakSource = Enumerable.Range(0, 1000).ToList();
            int BreakData = 0;
            Console.WriteLine("Using Loopstate ");
            Parallel.For(0, BreakSource.Count, (i, BreakLoopState) =>
            {
                BreakData += i;
                if (BreakData > 100)
                {
                    BreakLoopState.Break();
                    Console.WriteLine("Break called iteration " + i + " data= " + BreakData);
                }
            });
            Console.WriteLine("BreakData called data: " + BreakData);
        }
    }
}
