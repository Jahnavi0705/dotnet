using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelLoopforBreak
{
    public delegate void Adddelegate(int a, int b);
    public delegate void Subdelegate(int a, int b);
    public delegate void Muldelegate(int a, int b);
    public delegate void Divdelegate(double a, double b);
    public delegate void Remdelegate(double a, double b);
    internal class Calculatordelegate
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Div(double x, double y)
        {
            Console.WriteLine(x / y);
        }
        public void Rem(double x, double y)
        {
            Console.WriteLine(x % y);
        }
        static void Main4(string[] args)
        {
            Calculatordelegate obj = new Calculatordelegate();
            Adddelegate add = new Adddelegate(obj.Add);
            Subdelegate sub = new Subdelegate(obj.Sub);
            Muldelegate mul = new Muldelegate(obj.Mul);
            Divdelegate div = new Divdelegate(obj.Div);
            Remdelegate rem = new Remdelegate(obj.Rem);
            Console.WriteLine("Addition is: "  );
            add(100, 1);
            Console.WriteLine("Subtraction is: ");
            sub(50, 16);
            Console.WriteLine("Multiplication is: ");
            mul(50 , 75);
            Console.WriteLine("Division is: ");
            div(50, 17);
            Console.WriteLine("Reminder  is: ");
            rem(50, 17);
        }
    }
}
