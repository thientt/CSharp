using DecoratorPatternTut.Component;
using System;

namespace DecoratorPatternTut.ConcreteComponent
{
    public class TomatoPizza : Pizza
    {
        public override string MakePizza()
        {
            return ("I am a Tomato pizza");
        }
    }
}
