using System;

namespace outexample
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            //Console.WriteLine("Previous value of index"+index.ToString());
            string result = GetNameValueout(out index);
            int refIndex = 1;
            GetNameValueref(ref refIndex);
            Console.WriteLine("current value of index" + index.ToString());
        }
        public static string GetNameValueref(ref int id)
        {
            //string returnText = "Dummy name" + id.ToString();
            //id += 1;
            return id.ToString();


        }
        public static string GetNameValueout(out int id)
        {
            id = 1;
            //string returnText = "Dummy name" + id.ToString();
            //id += 1;
            return id.ToString();


        }
    }
}
