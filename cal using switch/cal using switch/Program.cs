using System;

namespace cal_using_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int cal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.ADD/n 2.SUB/n 3.MUL/n 4.Div/n "); 
            switch(cal)
            {
                case 1:
                    Console.WriteLine("Sum of "+a +" and"+b+" is: "+(a + b));
                    break;
                case 2:
                    Console.WriteLine("SubTraction of "+a +" and"+b+" is: "+(a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication of "+a+" &"+b+" is:"+(a * b));
                    break;
                case 4:
                    Console.WriteLine("Division of "+a+" &"+b+" is:"+(a / b));
                    break;
                
            default:
                    Console.WriteLine("Enter choice correctly");
                    break;

            }
        }
    }
}
