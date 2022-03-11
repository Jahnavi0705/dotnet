using System;
using System.IO;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //write in a file
            StreamWriter sw = new StreamWriter("D://File-Write//sample.txt");

            // to write a line in buffer
            sw.WriteLine("Writing value in a file");

            //write in output stream
            sw.Flush();
            sw.Close();
        }
    }
}
