
using System;

namespace Interfacess
{
    public interface IA
    {
        void method1();
    }
    public interface IB : IA
    {
        void method2();
    }
    class Z:IB
    {
        public void method2()
        {
            Console.WriteLine("Implemented method 2");
        }
        public void method1()
        {
            Console.WriteLine("Implemented method 1");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Z z = new Z();
            z.method1();
            z.method2();
            
        }
    }
}
