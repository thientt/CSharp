namespace StrategyPatternTut.Sample02.Strategy
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}