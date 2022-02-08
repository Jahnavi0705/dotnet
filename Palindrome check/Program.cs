using System;

namespace Palindrome_check
{
    public class Program
    {
        public static bool Palindrome(string text)
        {
            if(text.Length<=1)
            {
                return true;
            }
            else
            {
                if(text[0]!=text[text.Length-1])
                {
                    return false;
                }
                else
                {
                    return Palindrome(text.Substring(1, text.Length - 2));
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string text = Console.ReadLine();
            Console.WriteLine(Palindrome(text));
        }
    }
}
