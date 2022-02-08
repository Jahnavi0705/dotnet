using System;

namespace celsius
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            int celsius;
            Console.WriteLine("Number of degree in celsius: ");
            celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of degrees in Kelvin: " + (celsius + 273));
            Console.WriteLine("Number of degrees in Fahrenheit: " + (celsius*18/10 +32));

        }
    }
}
