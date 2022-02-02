using System;

namespace student_details
{
    class student
    {
        int rollnum;
        string name, gender, address, Course;

        public void getstudentinfo()
        {
            Console.WriteLine("Enter the  roll number:- ");
            rollnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name:- ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the  Gender:- ");
            gender = Console.ReadLine();
            Console.WriteLine("Enter the address:- ");
            address = Console.ReadLine();
            Console.WriteLine("Enter the  Course:- ");
            Course = Console.ReadLine();


           
        }
        public void display()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Student details are: ");
            Console.WriteLine("Roll no: " + rollnum);
            Console.WriteLine("Name:-"+name);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Course: "+Course);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student []stu = new student[3];
            for(int i=0; i<stu.Length;i++)
            {
                student stu1 = new student();
                stu1.getstudentinfo();
                stu[i] = stu1;
            }
            for(int i=0;i<stu.Length;i++)
            {
                stu[i].display();
            }
            
            
        }
    }
}
