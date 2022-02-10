using System;
using System.Threading;

namespace threading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Thread th = Thread.CurrentThread;
            Console.WriteLine("Hello World!");
            Console.WriteLine(th);
            Console.ReadLine();*/

            /*//example of synchronous
            Thread work1Thread = new Thread(work1);
            Thread work2Thread = new Thread(work2);
            work2();
            work1();*/

            //example of asynchronous
            Thread Work1Thread = new Thread(work1);
            Thread Work2Thread = new Thread(work2);
            Work1Thread.Start();
            Work2Thread.Start();

        }
        static void work1()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("work1: "+i.ToString());
            }
            
        }
        static void work2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("work2: "+i.ToString());
            }

        }
    }
}
