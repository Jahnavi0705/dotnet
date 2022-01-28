using System;
using System.Collections.Generic;
using System;

namespace jagged_array
{
    class Program
    {
        public static void Main(string[] args)
        {
            //example of jagged array
            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[5];
            jaggedarray[1] = new int[4];
            jaggedarray[2] = new int[2];

            jaggedarray[0] = new int[] { 1, 3, 5,7};
            jaggedarray[1] = new int[] { 11, 13, 15, 17 };
            jaggedarray[2] = new int[] { 11, 33 };
            for(int row = 0; row<jaggedarray.Length; row++)
            {
                Console.WriteLine("Row" + row);
                for (int col = 0; col < jaggedarray.Length; col++)
                {
                    Console.WriteLine(jaggedarray[row][col]);
                }
                Console.WriteLine();
            }
        }
        
    }
}
