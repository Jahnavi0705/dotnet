
using System;

namespace constructor
{
    class Samplec
    {
        int a, b;

        //default constructor
        //types of constructor
        //1.Default
        //2.Parameterized
        //3.Static
        //4.Private
        //5.Copy
        public Samplec()
        {

        }
        //parameterized constructor
        public Samplec(int _a,int _b)
        {
            a = _a;
            b = _b;
        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Samplec obj = new Samplec(1,2);
            Console.WriteLine("Hello World!");
        }
    }
}
