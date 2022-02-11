using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelLoopforBreak
{
    internal class GenericDelegates
    {
        public static double AddNumber1(int n1,float n2,double n3)
        {
            return n1 + n2 + n3;
        }
        public static void AddNumber2(int n1, float n2, double n3)
        {
            Console.WriteLine(n1 + n2 + n3);
        }
        public static bool CheckLength(string name)
        {
            if(name.Length>5)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);
            double Result = obj1.Invoke(100, 123.45f, 546.789);
            Console.WriteLine(Result);
            Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);
            obj2.Invoke(50, 224.51f, 4541.55);
            Predicate<string> obj3 = new Predicate<string>(CheckLength);
            bool status = obj3.Invoke("Jahnavi");
            Console.WriteLine(status);
        }
    }
}
