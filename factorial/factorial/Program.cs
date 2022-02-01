using System;

namespace factorial
{
    class Program
    {
        static void main(string[] args)
        {
            int i,n,fact;
            Console.WriteLine("Enter the input");
            n = Convert.ToInt32(Console.ReadLine());
            fact = n;
            for(i=n-1;i>=1;i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + n + " is:" + fact);
           



        }
        
    }
}
