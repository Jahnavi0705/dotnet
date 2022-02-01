using System;

namespace display_natural_no_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.WriteLine("Enter the input: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first " + n + " natural numbers are:");
            for(i=1;i<=n;i++)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("Sum of " + n + " natural numbers are: " + sum);
           
        }
    }
}
