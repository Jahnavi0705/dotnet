using System;

namespace ProgramConsoleApplication 
{
    class SampleProgram
    {
        static void Main1(string[] args)
        {
            int i, j;
            int[,] arr = new int[2, 2];
            for (i = 0; i < 2; ++i)
            {
                for (j = 0; j < 2; ++j)
                {
                    arr[i, j] = i * 17 + i * 17;
                    Console.Write(arr[i, j] + " ");
                }
            }
        }
    }
}
