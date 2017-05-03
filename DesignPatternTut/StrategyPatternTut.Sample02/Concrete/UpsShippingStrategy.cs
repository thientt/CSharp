using StrategyPatternTut.Sample02.Strategy;

namespace StrategyPatternTut.Sample02.Concrete
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 4.25d;
        }
    }
}