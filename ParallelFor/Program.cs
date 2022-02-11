using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelFor
{
    internal class Program
    {
        static void Main11(string[] args)
        {
            Console.WriteLine("C# for loop");
            int number = 10;
            for(int i=0;i<number;i++)
            {
                Console.WriteLine($"value of content={i},{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.WriteLine("Parallel for Loop");

            Parallel.For(0,number,i=>
                {
                Console.WriteLine($"value of count={i},{Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(10);
            });
            Console.ReadLine();
        }
    }
}
