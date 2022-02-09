using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace generic_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            string str = "Sample";
            int x = 10;
            DateTime dt = DateTime.Now;

            al.Add(x);
            al.Add((DateTime)dt);
            al.Add(str);
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }

            
            
        }
    }
}
