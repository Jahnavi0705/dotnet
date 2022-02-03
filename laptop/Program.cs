using System;

namespace laptop
{
    class LaptopBase
    {
        public const string laptop1 = "Lenovo";
        public const string laptop2 = "Sony";
        public const string laptop3 = "Dell";

        
        public const string price1 = "10000/-";
        public const string price2 = "20000/-";
        public const string price3 = "15000/-";


        public const string i3 = "i3";
        public const string i5 = "i5";
        public const string i7 = "i7";
        


        public const string Ram2 = "2GB";
        public const string Ram4 = "4GB";
        public const string Ram6 = "8GB";


        public const string HD1 = "500GB";
        public const string HD2 = "1024GB";
        public const string HD3 = "2TB";



    }
    class Laptop:LaptopBase
    {
        public void ShowDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Processor: " + processor);
            Console.WriteLine("Ram: " + ram);
            Console.WriteLine("HDD: " + hdd);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.ShowDetails(Laptop.laptop1, Laptop.price1, Laptop.i3, Laptop.Ram2, Laptop.HD1);
            Console.WriteLine("\n");
            laptop.ShowDetails(Laptop.laptop2, Laptop.price2, Laptop.i5, Laptop.Ram4, Laptop.HD2);
            Console.WriteLine("\n");
            laptop.ShowDetails(Laptop.laptop3, Laptop.price2, Laptop.i7, Laptop.Ram6, Laptop.HD3);
            Console.WriteLine("\n");
        }
    }
}
