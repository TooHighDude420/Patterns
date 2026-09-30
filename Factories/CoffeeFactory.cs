using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Factories
{
    enum CoffeTypes {
        ESPRESSO,
        CAPPUCHINO
    }

    internal abstract class CoffeeFactory
    {
        public Beverage OrderCoffee(CoffeTypes types)
        {
            Beverage beverage = CreateDrink(types);
            //todo add PrintBeverage
            
            return beverage;
        }

        public abstract Beverage CreateDrink(CoffeTypes types);
    }
}
