using DecoratorPatternTut.Component;
using System;

namespace DecoratorPatternTut.ConcreteComponent
{
    public class ChickenPizza : Pizza
    {
        public override string MakePizza()
        {
            return ("I am a chicken pizza");
        }
    }
}
