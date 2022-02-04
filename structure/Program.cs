using System;

namespace structure
{
    public struct Structure
    {
        private double val;
        public double Value
        {
            get { return val; }
            set { val = value; }
        }
        public double Read()
        {
            return double.Parse(Console.ReadLine());
        }
    }
    public struct shape
    {
        Structure l;
        Structure h;

        public Structure Length
        {
            get { return l; }
            set { l = value; }
        }
        public Structure Breadth
        {
            get { return h; }
            set { h = value; }
        }
        public void newShape()
        {
            Structure r = new Structure();
            Console.WriteLine("Input the dimensions of the Square( equal length and breadth ): ");
            l = sqrLength();
            Console.WriteLine("breadth:");
            h.Value = r.Read();
        }
        public Structure sqrLength()
        {
            Structure r = new Structure();
            Console.WriteLine("length: ");
            r.Value = r.Read();
            return r;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMethod that returns a structure  : ");
            var sqre = new shape();
            sqre.newShape();
            Console.WriteLine();
            Console.WriteLine("Perimeter and Area of the square: ");
            Console.WriteLine("Length: "+sqre.Length.Value);
            Console.WriteLine("Breadth: "+sqre.Breadth.Value);
            Console.WriteLine("Perimeter: "+(sqre.Length.Value+sqre.Breadth.Value)*2);
            Console.WriteLine("Area : "+sqre.Length.Value*sqre.Breadth.Value);
        }
    }
}
