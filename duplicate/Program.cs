using System;
using System.Collections.Generic;

namespace duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array: ");
            string arr = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char ch in arr.Replace(" ",string.Empty))
            {
                if(dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach(var item in dict.Keys)
            {
                Console.WriteLine(item + "-" + dict[item]);
            }
            Console.ReadKey();
        }
    }
}
