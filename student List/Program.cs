using System;
using System.Collections;

namespace student_List
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList stu = new ArrayList();
            Console.WriteLine("Enter student ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();

            stu.Add(new Student()
            {
                Name=name,
                ID=id,
            });
            foreach(Student s in stu)
            {
                Console.WriteLine(name + " - " + id);
            }
        }
    }
}
