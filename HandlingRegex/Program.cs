using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HandlingRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input: ");
            string a = Console.ReadLine();
            Regex re = new Regex("^[0-9]{4}$");

            Match match = re.Match(a);
            if(match.Success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Input valid string");
            }
            
        }
    }
}
