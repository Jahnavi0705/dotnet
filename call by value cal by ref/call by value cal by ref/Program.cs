using System;

namespace call_by_value_cal_by_ref
{
    class Program
    {
        //call by value call by reference
        //ref key word
        static void Main(string[] args)
        {
            int a = 6;
            int b = 5;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Value of a " + a + " and b=" + b);

        }
        static void swap(ref int a,ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
