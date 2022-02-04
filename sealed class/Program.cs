using System;

namespace sealed_class
{

    class Program
    {
        static public void sampleMethod(dynamic val)
        {
            Console.WriteLine(val.s_id);
            Console.WriteLine(val.s_name);
            Console.WriteLine(val.language);
            Console.WriteLine(val.nested_ob.email);
        }
        public static void print(int s)
        {

        }
        public static void Main(string[] args)
        {
            var anony_Object = new
            {
                s_id = 123,
                s_name = "Jahnavi",
                language = "English",
                nested_ob = new { email = "Jahnavi@gmail.com" }
            };
            sampleMethod(anony_Object);
        }
    }
}
