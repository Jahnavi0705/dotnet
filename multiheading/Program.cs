using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace multiheading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInformation1));
            Thread t2 = new Thread(new ThreadStart(PrintInformation2));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
        static void PrintInformation1()
        {
            for(int i=0;i<=4;i++)
            {
                Console.WriteLine("Value from first function: "+i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("First Method completed");
        }
        static void PrintInformation2()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Value from second function: " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Second Method completed");
        }
    }
}
