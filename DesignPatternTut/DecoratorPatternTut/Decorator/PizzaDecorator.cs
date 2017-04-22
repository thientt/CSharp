using DecoratorPatternTut.Component;

namespace DecoratorPatternTut.Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        protected Pizza Pizza
        {
            get; private set;
        }

        public PizzaDecorator(Pizza pizza)
        {
            Pizza = pizza;
        }
    }
}
