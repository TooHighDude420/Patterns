using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    internal class StarBuzzz : CoffeeFactory
    {
        public override Beverage CreateDrink(CoffeTypes types, Size? size = null)
        {
            switch (types)
            {
                case CoffeTypes.ESPRESSO:
                    return new Espresso(size);
                case CoffeTypes.DOPPIO:
                    Beverage doppio = new Espresso(size);
                    return new EspressoCon(doppio);
                case CoffeTypes.LUNGO:
                    Beverage lungo = new Espresso();
                    return new WaterCon(lungo);
                case CoffeTypes.MACCIATO:
                    Beverage macchiato = new Espresso(size);
                    return new MilkFoam(macchiato);
                case CoffeTypes.CORRETO:
                    Beverage correto = new Espresso(size);
                    return new Liqour(correto);
                case CoffeTypes.CONPANNA:
                    Beverage conPanna = new Espresso(size);
                    return new WhippedCream(conPanna);
                case CoffeTypes.CAPPUCHINO:
                    Beverage cappuchino = new Espresso();
                    cappuchino = new SteamedMilk(cappuchino);
                    return new MilkFoam(cappuchino);
                case CoffeTypes.AMERICANO:
                    Beverage americano = new Espresso(size);
                    americano = new WaterCon(americano);
                    return new WaterCon(americano);
                case CoffeTypes.CAFFELATTE:
                    Beverage caffeLatte = new Espresso(size);
                    caffeLatte = new SteamedMilk(caffeLatte);
                    return new MilkFoam(caffeLatte);
                case CoffeTypes.FLATWHITE:
                    Beverage flatWhite = new Espresso(size);
                    flatWhite = new SteamedMilk(flatWhite);
                    return new SteamedMilk(flatWhite);
                case CoffeTypes.ROMANO:
                    Beverage romano = new Espresso(size);
                    return new Lemon(romano);
                case CoffeTypes.MARACCHINO:
                    Beverage maracchino = new Espresso(size);
                    maracchino = new ChocolateCon(maracchino);
                    return new MilkFoam(maracchino);
                case CoffeTypes.MOCCHA:
                    Beverage moccha = new Espresso(size);
                    moccha = new ChocolateCon(moccha);
                    moccha = new MilkFoam(moccha);
                    return new WhippedCream(moccha);
                case CoffeTypes.BICERIN:
                    Beverage bicerin = new Espresso(size);
                    bicerin = new BlackChocolateCon(bicerin);
                    bicerin = new WhiteChocolateCon(bicerin);
                    return new WhippedCream(bicerin);
                case CoffeTypes.BREVE:
                    Beverage breve = new Espresso(size);
                    breve = new MilkCon(breve);
                    return new MilkFoam(breve);
                case CoffeTypes.RAFCOFFEE:
                    Beverage rafCoffee = new Espresso(size);
                    rafCoffee = new VanillaSugar(rafCoffee);
                    return new Cream(rafCoffee);
                case CoffeTypes.MEADRAF:
                    Beverage meadRaf = new Espresso(size);
                    meadRaf = new Honey(meadRaf);
                    return new Cream(meadRaf);
                case CoffeTypes.GELATO:
                    Beverage gelato = new Espresso(size);
                    return new MilkFoam(gelato);
                case CoffeTypes.CAFEALLOGATO:
                    Beverage cafeeAllogato = new IceCream(size);
                    return new EspressoCon(cafeeAllogato);
                case CoffeTypes.VIENNACOFFEE:
                    Beverage viennaCoffee = new Espresso(size);
                    return  new WhippedCream(viennaCoffee);
                case CoffeTypes.GLACE:
                    Beverage glace = new Espresso(size);
                    return new IceCreamCon(glace);
                case CoffeTypes.CHOCOLATEMILK:
                    Beverage chocolateMilk = new Cocao(size);
                    return new MilkCon(chocolateMilk);
                case CoffeTypes.DEMICREME:
                    Beverage demiCreme = new Espresso(size);
                    return new Cream(demiCreme);
                case CoffeTypes.LATTEMACCHIATO:
                    Beverage latteMacchiato = new SteamedMilkBev(size);
                    latteMacchiato = new EspressoCon(latteMacchiato);
                    return new MilkFoam(latteMacchiato);
                case CoffeTypes.FREDDO:
                    Beverage freddo = new Espresso(size);
                    freddo = new Liqour(freddo);
                    return new Ice(freddo);
                case CoffeTypes.FRAPPUCCINO:
                    Beverage frappuccino = new Espresso(Size.VENDI);
                    frappuccino = new Ice(frappuccino);
                    frappuccino = new SteamedMilk(frappuccino);
                    return new WhippedCream(frappuccino);
                case CoffeTypes.CARAMELFRAPPUCHINO:
                    Beverage caramelFrappuchino = new Espresso(size);
                    caramelFrappuchino = new Ice(caramelFrappuchino);
                    caramelFrappuchino = new SteamedMilk(caramelFrappuchino);
                    return new CreamAndSyrup(caramelFrappuchino);
                case CoffeTypes.FRAPPE:
                    Beverage frappe = new Espresso(size);
                    frappe = new SteamedMilk(frappe);
                    return new IceCreamCon(frappe);
                case CoffeTypes.IRISHCOFFEE:
                    Beverage irishCoffee = new Espresso(size);
                    irishCoffee = new Whiskey(irishCoffee);
                    return new WhippedCream(irishCoffee);
                default:
                    throw new IllegalArgumentException("Coffee type not supported");
            }
        }
    }

    [Serializable]
    internal class IllegalArgumentException : Exception
    {
        public IllegalArgumentException()
        {
        }

        public IllegalArgumentException(string? message) : base(message)
        {
        }

        public IllegalArgumentException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
