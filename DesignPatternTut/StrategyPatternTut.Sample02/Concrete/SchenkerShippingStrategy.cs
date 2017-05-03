using StrategyPatternTut.Sample02.Strategy;

namespace StrategyPatternTut.Sample02.Concrete
{
    public class SchenkerShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 3.3d;
        }
    }
}