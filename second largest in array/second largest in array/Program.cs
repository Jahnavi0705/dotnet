using System;

namespace second_largest_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, seclarg;
            int[] arr = new int[5];

            Console.Write("Enter five numbers:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        seclarg = arr[i];
                        arr[i] = arr[j];
                        arr[j] = seclarg;
                    }
                }
            }
            Console.WriteLine("Second largest element is:" + arr[5 - 2]);
        }
    }
}
