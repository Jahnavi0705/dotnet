using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Class2
    {
        static void Main3(string[] args)
        {
            int i, j;
            int[,] arr = new int[3, 3];
            for (i = 0; i < 3; ++i) 
            {
                for (j = 0; j < 3; ++j)
                {
                    arr[i, j] = i * 2 + i * 2; 
                    Console.WriteLine(arr[i, j]);
                } 
                Console.ReadLine();
            }
        }
    }
}
