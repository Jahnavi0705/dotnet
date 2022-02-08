using System;

namespace car_struct
{
    class Program
    {
        struct Car
        {
            public string Model;
            public int YearOfProduction;
        }
        static void Main(string[] args)
        {
            int total = 3;
            Car[] cars = new Car[total];
            for(int i=0; i<total;i++)
            {
                cars[i] = new Car()
                {
                    Model=Console.ReadLine(),
                    YearOfProduction = int.Parse(Console.ReadLine())
                };
            }

            for(int i=0; i<total-1;i++)
            {
                for(int j=i+1;j<total;j++)
                {
                    if(cars[i].YearOfProduction>cars[j].YearOfProduction)
                    {
                        var a = cars[i];
                        cars[i] = cars[j];
                        cars[j] = a;

                    }
                }
            }
            for(int i=0; i<total;i++)
            {
                var car = cars[i];
                Console.WriteLine("Model: "+car.Model+", Year of Manufactured:"+car.YearOfProduction);
            }
            
        }
    }
}
