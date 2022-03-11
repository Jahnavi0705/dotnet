using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LINQ
{
    delegate bool FindStudent(Student std);
    class StudentExtension
    {
        public static Student[] where (Student[] stdArray, FindStudent del)
        {
            int i = 0;
            Student[] result = new Student[10];
            foreach(var item in stdArray)

            {
                if(del(item))
                {
                    result[i] = item;
                    i++;
                }
            }
            return result;
        }
    }
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Class1
    {
        static void Main2(string[] args)
        {
            Student[] studentsArray =
            {
                new Student{StudentId=1,Age=18,StudentName="John"},
                new Student{StudentId=2,Age=19,StudentName="Kumar"},
                new Student{StudentId=3,Age=20,StudentName="Ravi"},
                new Student{StudentId=4,Age=25,StudentName="Ram"},
                new Student{StudentId=5,Age=35,StudentName="Bob"},
            };

            Student[] teenagerstudent = studentsArray.Where(s => s.Age > 12 && s.Age < 20).ToArray();
            Student bill = studentsArray.Where(s => s.StudentName == "Bob").FirstOrDefault();
            foreach(var item in teenagerstudent)
            {
                Console.WriteLine(item.StudentId + " " + item.Age + " " + item.StudentName);
            }

            Console.WriteLine(bill.StudentId + " " + bill.Age + " " + bill.StudentName);
        }
    }
}
