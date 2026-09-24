using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        //adapter patern toepassen
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            Beverage doppio = new Espresso();
            doppio = new BevToCon(doppio, new Espresso());
            PrintBeverage(doppio);

            Beverage lungo = new Espresso();
            lungo = new BevToCon(lungo, new Water());
            PrintBeverage(lungo);

            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            PrintBeverage(macchiato);

            Beverage correto = new Espresso();
            correto = new Liqour(correto);
            PrintBeverage(correto);

            Beverage conPanna = new Espresso();
            conPanna = new WhippedCream(conPanna);
            PrintBeverage(conPanna);

            Beverage cappuchino = new Espresso();
            cappuchino = new SteamedMilk(cappuchino);
            cappuchino = new MilkFoam(cappuchino);
            PrintBeverage(cappuchino);

            Beverage americano = new Espresso();
            americano = new BevToCon(americano, new Water());
            americano = new BevToCon(americano, new Water());
            PrintBeverage(americano);

            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            PrintBeverage(caffeLatte);

            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            PrintBeverage(flatWhite);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}