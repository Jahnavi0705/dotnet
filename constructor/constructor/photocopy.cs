using System;
using System.Collections.Generic;
using System.Text;

namespace constructor
{
    public class Photobook
    {
        int numPages,i;

        public Photobook()
        {
            numPages = 16;
            Console.WriteLine("Enter num of pages we want: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of pages are: " + i);
        }


        public int GetNumberPages()
        {
            return numPages;
        }

    }
     
    class Photocopy
    {
        
        static void Main(string[] args)
        {
            Photobook book = new Photobook();
            book.GetNumberPages();
        }
    }
}
