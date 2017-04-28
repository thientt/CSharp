using StrategyPatternTut.Sample02.Strategy;
using System;

namespace StrategyPatternTut.Sample02.Services
{
    public class ShippingCostCalculationService
    {
        private IShippingStrategy _shippingStrategy;

        public ShippingCostCalculationService()
        {
        }

        public ShippingCostCalculationService(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            if (_shippingStrategy == null)
                throw new ArgumentNullException("Shipping don't null");

            return _shippingStrategy.Calculate(order);
        }

        public double CalculateShippingCost(Order order, Func<Order, double> shippingCost)
        {
            return shippingCost(order);
        }
    }
}
