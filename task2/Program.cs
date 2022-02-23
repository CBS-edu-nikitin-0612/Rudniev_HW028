using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Brand = "Audi",
                    Model = "TT Roadster",
                    Year = 2015,
                    Color = "Brown"
                },
                new Car
                {
                    Brand = "Audi",
                    Model = "RS Q8",
                    Year = 2022,
                    Color = "Silver"
                },
                new Car
                {
                    Brand = "Audi",
                    Model = "A8",
                    Year = 2021,
                    Color = "Blue"
                },
                new Car
                {
                    Brand = "Audi",
                    Model = "A5 Sportback",
                    Year = 2019,
                    Color = "Black"
                },
            };
            var buyers = new List<Buyer>
            {
                new Buyer
                {
                    Model = "TT Roadster",
                    Name = "Rudniev Vladyslav",
                    PhoneNumber = "+380684844686"
                },
                new Buyer
                {
                    Model = "A4 S",
                    Name = "Popov Ivan",
                    PhoneNumber = "+380995457132"
                },
                new Buyer
                {
                    Model = "A5 Sportback",
                    Name = "Kretov Oleg",
                    PhoneNumber = "+380935773231"
                },
            };

            var allInfoOfBuyerAndCar = cars
                .Join(buyers, car => car.Model, buyer => buyer.Model, (car, buyer) => new
                {
                    Brand = car.Brand,
                    Model = car.Model,
                    Year = car.Year,
                    Color = car.Color,
                    BuyersName = buyer.Name,
                    PhonesNumber = buyer.PhoneNumber
                })
                .ToList();

            foreach (var info in allInfoOfBuyerAndCar)
                Console.WriteLine($"Info of car: {info.Brand} {info.Model} {info.Year}, color {info.Color}.\n" +
                    $"Buyer: {info.BuyersName}, {info.PhonesNumber};\n" +
                    new string('-', 60));
        }
    }
}
