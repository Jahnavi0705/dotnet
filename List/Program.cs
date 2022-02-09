using System;
using System.Collections;

namespace List
{
    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name + "  -  " + Age;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            int age = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            list.Add(new Person()
            {
                Name = name,
                Age =age,
            }) ;
            foreach(Person p in list)
            {
                Console.WriteLine(p.ToString());
            }
            //Console.ReadLine();
        }
    }
}
