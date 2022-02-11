using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelLoopforBreak
{
    internal class forEachLoopSample
    {
        static void Main2(string[] args)
        {
            DateTime datetime = DateTime.Now;
            Console.WriteLine("Foreeach loop");

            List<int> integerList = Enumerable.Range(1, 10).ToList();
            foreach(var item in integerList)
            {
                long total = DoSomethingtoConsumeTime();
                Console.WriteLine(item+"-" +total);
            }
            DateTime Endtime = DateTime.Now;
            TimeSpan span = Endtime - datetime;
            int ms = (int)span.TotalMilliseconds;
            Console.WriteLine("Time taken in milliseconds " + ms);

        }
        static long DoSomethingtoConsumeTime()
        {
            long total = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
