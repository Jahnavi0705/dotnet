using System;

namespace duplicate_value_arra
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i, j, n, count = 0;

            Console.WriteLine("Enter the size:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in array: ");
            for(i=0; i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(i=0;i<n;i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        count++;
                        break;
                    }
                    
                }
            }
            Console.WriteLine("Total number of duplicate elements in array are:" + count);
        }
        

    }
}
