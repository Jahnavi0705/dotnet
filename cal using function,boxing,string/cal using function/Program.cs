using System;

namespace cal_using_function
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;
            Console.WriteLine("object value is: "+o);

            int[] cnumber = { 10, 20, 30, 40, 50 };
            for(i = 0; i < cnumber.Length;i++)
            {
                Console.WriteLine(cnumber[i]);
            }
            Console.WriteLine("Enter two values: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            cal(ref a, ref b);
        }
        static void cal(ref int a, ref int b)
        {
            int sum, multiply, subtraction;
            sum = a + b;
            Console.WriteLine("Sum of " + a + " & " + b + " is:" + sum);
            multiply = a * b;
            Console.WriteLine("Product of " + a + " & " + b + " is:" + multiply);
            subtraction = a - b;
            Console.WriteLine("Subtraction of " + a + " & " + b + " is:" + subtraction);
        }

    }
}
