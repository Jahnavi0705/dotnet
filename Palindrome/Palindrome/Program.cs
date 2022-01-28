using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string samplename = "vikash", revs = "";
            for (int i = 0; i < samplename.Length; i++)
            {
                revs += samplename[i].ToString();
            }
            if (revs == samplename)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not a palindrome");
            }
        }
    }
}
