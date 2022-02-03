using System;

namespace inheritence
{
    class Person
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Good Morning...");
        }
        //int age;
        public void SetAge(int _age)
        {

            age = _age;
        }
        
    }

    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge(int age)
        {
            Console.WriteLine("My age is "+age+"years old");
        }
    }
    class Teacher:Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
    

    class StudentProfessor
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(10);
            student.Greet();
            student.ShowAge(10);

            Teacher teacher = new Teacher();
            teacher.SetAge(22);
            teacher.Greet();
            teacher.Explain();


        }
    }
}
