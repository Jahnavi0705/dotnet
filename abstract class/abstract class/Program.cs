using System;
using System.Collections.Generic;
using System.Text;

namespace abstract_class
{
    public abstract class Animal
    {
        private string Name;
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public abstract void Eat();

        
    }
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog is eating...");
        }
    }


    class Program
    {
        

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Dog's name? ");
            dog.SetName(Console.ReadLine());
            Console.WriteLine("Dog's name is " + dog);
            Console.WriteLine(dog.GetName());
            dog.Eat();
            
        }
    }
}
