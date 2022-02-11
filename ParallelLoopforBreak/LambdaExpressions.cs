using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelLoopforBreak
{
    internal class LambdaExpressions
    {
        public delegate string GreetDelegate(string name);
        static void Main8(string[] args)
        {
            String Message = " Hey ";
            GreetDelegate gd = (name) =>
            {
                return " Hello "  + name + Message;
            };
            Console.WriteLine(gd.Invoke("JAHNAVI"));
        }
    }
}
