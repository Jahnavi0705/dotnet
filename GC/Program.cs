using System;
using System.Collections.Generic;
using System.Text;

namespace Garbage
{ 
    class calculator
    {
        public int Add(int a, int b)
        {
            return (a + b);
        }
        public int Sub(int a, int b)
        {
            return (a - b);
        }
        public int Mul(int a, int b)
        {
            return (a * b);
        }
        public float Div(int a, int b)
        {
            return (a / b);
        }
           
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator cal = new calculator();
            Console.WriteLine("Calculator object is now on "+GC.GetGeneration(cal)+"Generation");
            Console.WriteLine("Garbage collection occured at 0th generation " + GC.GetGeneration(0));
            Console.WriteLine("Garbage collection occured at 1th generation " + GC.GetGeneration(1));
            Console.WriteLine("Garbage collection occured at 2th generation " + GC.GetGeneration(2));
            GC.Collect(1);
            Console.WriteLine("Garbage collection occured at 0th generation " + GC.GetGeneration(0));

        }
    }
}
