using System;

namespace house
{
    public class House
    {
        public int Area;
        public Door door;

        public House(int area = 200)
        {
            Area = area;
        }
        public void ShowData()
        {
            Console.WriteLine("I am a house, my area is " + Area + "m2");
        }
        public Door GetDoor()
        {
            return door;
        }
        public class Door
        {
            public string Color;
            public Door(string color = "Brown")
            {
                Color = color;
            }
            public void ShowData()
            {
                Console.WriteLine("I am a door, my color is " + Color);
            }

        }
    }
    public class SmallApartment:House
    {
        public SmallApartment(int area = 50) : base(area)
        {

        }
    }
    public class Person
    {
        private string name;
        public House house;

        public Person(string name)
        {
            this.name = name;
        }
        public void ShowData()
        {
            Console.WriteLine("A person whose name is " + name);
            Console.WriteLine("Data of house: ");
            house.ShowData();
            Console.WriteLine("Data of door: ");
            house.GetDoor().ShowData();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("Jahnavi");
            apartment.door = new House.Door("brown");
            person.house = apartment;
            person.ShowData();
            
        }
    }
}
