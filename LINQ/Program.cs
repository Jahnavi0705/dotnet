using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main1(string[] args)
        {
            string[] names = { "Bill", "James", "Mohan", "Jahnavi" };
            //var linqquery = from name in names where name.Contains('a') select name;
            var linqquery = from name in names select name;
            foreach (var item in linqquery)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
