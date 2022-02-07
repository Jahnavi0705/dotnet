using System;

namespace Generics
{
    internal class Program
    {
        //we use <> to specify the parameter type
        //generic class

        public class sample<T>
        {
            //field
            private T data; 
            //property
            public T value
            {
                //accesors
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }
       

            }
        }
        public class Student
        {
            public int StudentID { get; set; }
            public string StudentName { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
        }
             
        
        static void Main(string[] args)
        {
            sample<string> name = new sample<string>();
            name.value = "Jahnavi";

            sample<float> version = new sample<float>();
            version.value = 5.0F;

            Console.WriteLine(name.value);
            Console.WriteLine(version.value);

            Student std = new Student()
            {
                StudentID = 1,
                StudentName = "Jahnavi",
                Age = 22,
                Address="Hyd"
            };

            Console.WriteLine("\n");
            Console.WriteLine("Student infromation:");
            Console.WriteLine(std.StudentID);
            Console.WriteLine(std.StudentName);
            Console.WriteLine(std.Age);
            Console.WriteLine(std.Address);

        }
    }
}
