using System;

namespace vehicle
{
    public interface IVehicle
    {
        void Drive();
        bool Refuel(int amount);

    }
    public class Car:IVehicle
    {
        public int Fuel;
        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {
            if(Fuel>0)
            {
                Console.WriteLine("Car is Driving");
            }
            else
            {
                Console.WriteLine("Car is not Driving");
            }
        }
        public bool Refuel(int amount)
        {
            Fuel += amount;
            return true;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            int fuel = int.Parse(Console.ReadLine());
            if(car.Refuel(fuel))
            {
                car.Drive();
            }
           // Console.WriteLine("Hello World!");
        }
    }
}
