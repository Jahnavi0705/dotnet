using System;

namespace division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            do
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 != 0)
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Division is {0}", num1 / num2);
                        Console.WriteLine("Remainder is {0}", num1 % num2);
                        Console.WriteLine();
                    }
                }
            }
            while (num1 != 0);
            
        }
    }
}
