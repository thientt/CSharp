using System;
using Faker;
using StrategyPatternTut.Sample02.Concrete;
using StrategyPatternTut.Sample02.Services;
using StrategyPatternTut.Sample02.Strategy;

namespace StrategyPatternTut.Sample02
{
    internal class Program
    {
        private static void Main()
        {
            var order = new Order
            {
                Destination = new Address
                {
                    AddressLine1 = Faker.Address.StreetAddress(),
                    AddressLine2 = Faker.Address.StreetAddress(),
                    AddressLine3 = Faker.Address.StreetAddress(),
                    City = Faker.Address.City(),
                    ContactName = Name.FullName(),
                    Country = Faker.Address.Country(),
                    PostalCode = Faker.Address.UkPostCode(),
                    Region = Faker.Address.ZipCode()
                },
                Origin = new Address
                {
                    AddressLine1 = Faker.Address.StreetAddress(),
                    AddressLine2 = Faker.Address.StreetAddress(),
                    AddressLine3 = Faker.Address.StreetAddress(),
                    City = Faker.Address.City(),
                    ContactName = Name.FullName(),
                    Country = Faker.Address.Country(),
                    PostalCode = Faker.Address.UkPostCode(),
                    Region = Faker.Address.ZipCode()
                }
            };

            IShippingStrategy shipping = new SchenkerShippingStrategy();
            var service = new ShippingCostCalculationService();
            Console.WriteLine("Schenker Shipping {0}", service.CalculateShippingCost(order, o => shipping.Calculate(o)));

            shipping = new FedexShippingStrategy();
            Console.WriteLine("Fedex Shipping {0}", service.CalculateShippingCost(order, o => shipping.Calculate(o)));

            shipping = new UpsShippingStrategy();
            Console.WriteLine("Ups Shipping {0}", service.CalculateShippingCost(order, o => shipping.Calculate(o)));

            Console.Read();
        }
    }
}