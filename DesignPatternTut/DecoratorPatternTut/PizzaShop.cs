using DecoratorPatternTut.Component;
using DecoratorPatternTut.ConcreteComponent;
using DecoratorPatternTut.ConcreteDecorator;
using System;

namespace DecoratorPatternTut
{
    public static class PizzaShop
    {
        public static void ExecuteDecorator()
        {
            Pizza tomato = new TomatoPizza();
            Pizza chicken = new ChickenPizza();

            Console.WriteLine(tomato.MakePizza());
            Console.WriteLine(chicken.MakePizza());

            // Use Decorator pattern to extend existing pizza dynamically

            // Add pepper to tomato-pizza
            PepperDecorator pepperDecorator = new PepperDecorator(tomato);
            Console.WriteLine(pepperDecorator.MakePizza());

            // Add cheese to tomato-pizza
            CheeseDecorator cheeseDecorator = new CheeseDecorator(tomato);
            Console.WriteLine(cheeseDecorator.MakePizza());

            // Add cheese and pepper to tomato-pizza
            // We combine functionalities together easily.
            CheeseDecorator cheeseDecorator2 = new CheeseDecorator(pepperDecorator);
            Console.WriteLine(cheeseDecorator2.MakePizza());
        }
    }
}
