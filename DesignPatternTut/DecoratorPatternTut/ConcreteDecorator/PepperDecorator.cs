using DecoratorPatternTut.Component;
using DecoratorPatternTut.Decorator;

namespace DecoratorPatternTut.ConcreteDecorator
{
    public class PepperDecorator : PizzaDecorator
    {
        public PepperDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string MakePizza()
        {
            return Pizza.MakePizza() + AddPepper();
        }

        /// <summary>
        /// Add pepper to pizza
        /// pepper: tieu
        /// </summary>
        /// <returns></returns>
        private string AddPepper()
        {
            return " + Pepper";
        }
    }
}
