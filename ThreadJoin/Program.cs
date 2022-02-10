using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(MethodJoin);
            Console.WriteLine(thread.ThreadState);
            thread.Start();
            Console.WriteLine(thread.ThreadState);
            thread.Join();
            Console.WriteLine(thread.ThreadState);
            //thread.Abort();
            Console.WriteLine(thread.ThreadState);
            Console.WriteLine("Work completed");
        }
        static void MethodJoin()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("work in progress");
            }
        }
    }
}
