using DecoratorPatternTut.Component;
using DecoratorPatternTut.Decorator;

namespace DecoratorPatternTut.ConcreteDecorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return Pizza.MakePizza() + AddCheese();
        }

        /// <summary>
        /// Add cheese to pizza
        /// chees: pho mai
        /// </summary>
        /// <returns></returns>
        private string AddCheese()
        {
            return " + Cheese";
        }
    }
}
