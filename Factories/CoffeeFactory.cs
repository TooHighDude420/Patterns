using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Factories
{
    //todo add all coffetypes
    enum CoffeTypes
    {
        ESPRESSO,
        DOPPIO,
        LUNGO,
        MACCIATO,
        CORRETO,
        CONPANNA,
        CAPPUCHINO,
        AMERICANO,
        CAFFELATTE,
        FLATWHITE,
        ROMANO,
        MARACCHINO,
        MOCCHA,
        BICERIN,
        BREVE,
        RAFCOFFEE,
        MEADRAF,
        GELATO,
        CAFEALLOGATO,
        VIENNACOFFEE,
        GLACE,
        CHOCOLATEMILK,
        DEMICREME,
        LATTEMACCHIATO,
        FREDDO,
        FRAPPUCCINO,
        CARAMELFRAPPUCHINO,
        FRAPPE,
        IRISHCOFFEE
    }

    internal abstract class CoffeeFactory
    {
        public Beverage OrderCoffee(CoffeTypes type, Size? size = null)
        {
            Beverage beverage = CreateDrink(type, size);
            PrintBeverages(beverage);
            
            return beverage;
        }

        static void PrintBeverages(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.costs().ToString("#.##") + " size:" + beverage.Size.ToString());
        }

        public abstract Beverage CreateDrink(CoffeTypes types, Size? size);
    }
}
