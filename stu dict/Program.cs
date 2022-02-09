using System;
using System.Collections.Generic;
using System.Text;

namespace stu_dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Dictionary<string, string> stu = new Dictionary<string, string>();
            Console.WriteLine("Enter Student's ID and Name:  ");
            
            
            
            for(int i=1;i<=3;i++)
            {
                stu.Add(Console.ReadLine(),Console.ReadLine());
            }
            Console.WriteLine("ID  -  Name");
            foreach(var item in stu)
            {
                Console.WriteLine(item.Key + "  -  " + item.Value) ;
            }
        }
    }
}
