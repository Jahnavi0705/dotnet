using System;

namespace first
{
    class Program
    {
        static void Main(string[] args)
        {
            //data type and a is your variable
            //int a=5,b=6;
            double a = 7.5, b = 5.2;
            //char s = 'c';
            string s1 = "jahnavi";
            Console.WriteLine(a * b);
            //Console.WriteLine(s);
            Console.WriteLine(s1);

            //greater
            if (a > b) //expression
            {
                Console.WriteLine("a is greater");
            }
            else
            {
                Console.WriteLine("b is greater");
            }

            //swap
            int c = 6, d = 8, temp;
            temp = c;
            c = d;
            d = temp;
            Console.WriteLine(c+","+d);

            //dynamic values
            
            Console.WriteLine("Enter the value");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            //swap

            Console.WriteLine("before swapping x = " + x + " y= " + y);
            x = x * y;
            y = x / y;
            x = x / y;
            Console.WriteLine("after swapping x = " + x + " y= " + y);
            
            //greater

            if (x>y)
            {
                Console.WriteLine(x + "is greater");
            }
            else
            {
                Console.WriteLine(y + "is greater");
            }

            //create a program to check whether a person is able to vote or not
            Console.WriteLine("Enter the age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age>60)
            {
                Console.WriteLine("Senior Citizen");
            }
            else if(age>=18)
            {
                Console.WriteLine("person can vote");
            }
            else
            {
                Console.WriteLine("person cannot vote");
            }

            //logical expressions
            //! not
            //&& and
            //|| or


        }
    }
}
