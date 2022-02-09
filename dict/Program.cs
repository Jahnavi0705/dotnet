using System;
using System.Collections.Generic;
using System.Text;

namespace dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> PL = new Dictionary<int, string>();
            Console.WriteLine("Enter the Language: ");
            for(int i=0;i<=3;i++)
            {
                PL.Add(i, Console.ReadLine());
            }
            foreach (var item in PL)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
            }*/

            Console.WriteLine("Example of List");
            List<string> list = new List<string>();
            Console.WriteLine("Enter student ");
            for (int i = 1; i < 3; i++)
            {
                list.Add(Console.ReadLine());
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
