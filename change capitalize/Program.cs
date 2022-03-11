using System;

namespace change_capitalize
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            char ch;
            Console.WriteLine("Enter input:  ");
            str = Console.ReadLine();

            System.Text.StringBuilder Str = new System.Text.StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    ch = Char.ToUpper(str[i]);
                    Str.Append(ch);
                }
                else if (char.IsUpper(str[i]))
                {
                    ch = char.ToLower(str[i]);
                    Str.Append(ch);
                }
                else
                {
                    ch = str[i];
                    Str.Append(ch);
                }
            }
            Console.WriteLine("After converting:  " + Str);
        }
    }
}
