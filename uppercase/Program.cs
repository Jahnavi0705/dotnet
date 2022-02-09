using System;
using System.Collections.Generic;

using System.Collections;
using System.Linq;

namespace uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = test(new List<string>(new string[] { "Jahnavi" ,"Kolukuluri"}));
            foreach(var i in list)
            {
                Console.WriteLine(i.ToString() + " ");
            }
            
        }
        public static List<string> test(List<string> str)
        {
            IEnumerable<string> s = str.Select(x => x.ToUpper());
            return s.ToList();
        }
    }
}
