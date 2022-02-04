using System;

namespace imaginary_real_part
{
    class ComplexNumber
    {
        protected double a, b;

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            a = realPart;
            b = imaginaryPart;
        }

        public double GetReal()
        {
            return a;
        }

        public double GetImaginary()
        {
            return b;
        }
        public void SetImaginary(double b)
        {
            this.b = b;
        }

        public new string ToString()
        {
            return "(" + a + "," + b + ")";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(ComplexNumber c2)
        {
            a += c2.GetReal();
            b += c2.GetImaginary();
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            bool debug = false;
            ComplexNumber number = new ComplexNumber(5, 2);
            Console.WriteLine("Number is: " + number.ToString());

            number.SetImaginary(-3);
            Console.WriteLine("Number is : " + number.ToString());
            Console.WriteLine("Magnitude is: ");
            Console.WriteLine(number.GetMagnitude());
            ComplexNumber number2 = new ComplexNumber(-1, 1);
            number.Add(number2);
            Console.WriteLine("After adding: ");
            Console.WriteLine(number.ToString());

            if(debug)
            {
                Console.ReadLine();

            }
        }
    }
}
