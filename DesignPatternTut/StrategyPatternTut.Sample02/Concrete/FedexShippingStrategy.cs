using StrategyPatternTut.Sample02.Strategy;

namespace StrategyPatternTut.Sample02.Concrete
{
    public class FedexShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5.00d;
        }
    }
}