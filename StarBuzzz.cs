using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class StarBuzzz : CoffeeFactory
    {
        public override Beverage CreateDrink(CoffeTypes types)
        {
            switch (types)
            {
                case CoffeTypes.ESPRESSO:
                    break;
                case CoffeTypes.CAPPUCHINO:
                    break;
                case default:
                    return;
            }
        }
    }
}
