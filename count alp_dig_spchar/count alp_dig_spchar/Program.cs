using System;

namespace count_alp_dig_spchar
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int alphabet, digit, splchar, i, l;
            alphabet = digit = splchar = i = 0;

            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            l = str.Length;

            while(i<l)
            {
                if((str[i]>='a' && str[i]<='z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if(str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    splchar++;
                }
                i++;
            }
            Console.WriteLine("No of alphabets in string are: " + alphabet);
            Console.WriteLine("No of digits in string are: " + digit);
            Console.WriteLine("No of special characters in string are: " + splchar);
        }
    }
}
