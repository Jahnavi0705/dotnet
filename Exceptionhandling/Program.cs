using System;

namespace Exceptionhandling
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;
            try
            {
                throw new Exception("Some error have occured");
                Console.WriteLine("Value of a is"+a);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Hi I am in finally block");
            }
        }
    }
}
