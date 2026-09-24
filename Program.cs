using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Helpers;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beverage> beverages = new List<Beverage>();

            Beverage espresso = new Espresso();
            beverages.Add(espresso);

            Beverage doppio = new Espresso();
            doppio = new BevToCon(doppio, new Espresso());
            beverages.Add(doppio);

            Beverage lungo = new Espresso();
            lungo = new BevToCon(lungo, new Water());
            beverages.Add(lungo);

            Beverage macchiato = new Espresso();
            macchiato = new MilkFoam(macchiato);
            beverages.Add(macchiato);

            Beverage correto = new Espresso();
            correto = new Liqour(correto);
            beverages.Add(correto);

            Beverage conPanna = new Espresso();
            conPanna = new WhippedCream(conPanna);
            beverages.Add(conPanna);

            Beverage cappuchino = new Espresso();
            cappuchino = new SteamedMilk(cappuchino);
            cappuchino = new MilkFoam(cappuchino);
            beverages.Add(cappuchino);

            Beverage americano = new Espresso();
            americano = new BevToCon(americano, new Water());
            americano = new BevToCon(americano, new Water());
            beverages.Add(americano);

            Beverage caffeLatte = new Espresso();
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            beverages.Add(caffeLatte);

            Beverage flatWhite = new Espresso();
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            beverages.Add(flatWhite);

            Beverage romano = new Espresso();
            romano = new Lemon(romano);
            beverages.Add(romano);

            Beverage maracchino = new Espresso();
            maracchino = new BevToCon(maracchino, new Chocolate());
            maracchino = new MilkFoam(maracchino);
            beverages.Add(maracchino);

            Beverage moccha = new Espresso();
            moccha = new BevToCon(moccha, new Chocolate());
            moccha = new MilkFoam(moccha);
            moccha = new WhippedCream(moccha);
            beverages.Add(moccha);

            Beverage bicerin = new Espresso();
            bicerin = new BevToCon(bicerin, new BlackChocolate());
            bicerin = new BevToCon(bicerin, new WhiteChocolate());
            bicerin = new WhippedCream(bicerin);
            beverages.Add(bicerin);

            Beverage breve = new Espresso();
            breve = new BevToCon(breve, new Milk());
            breve = new MilkFoam(breve);
            beverages.Add(breve);

            Beverage rafCoffee = new Espresso();
            rafCoffee = new VanillaSugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            beverages.Add(rafCoffee);

            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            beverages.Add(meadRaf);

            Beverage gelato = new Espresso();
            gelato = new MilkFoam(gelato);
            beverages.Add(gelato);

            Beverage cafeeAllogato = new IceCream();
            cafeeAllogato = new BevToCon(cafeeAllogato, new Espresso());
            beverages.Add(cafeeAllogato);
            
            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new WhippedCream(viennaCoffee);
            beverages.Add(viennaCoffee);

            Beverage glace = new Espresso();
            glace = new BevToCon(glace, new IceCream());
            beverages.Add(glace);

            Beverage chocolateMilk = new Cocao();
            chocolateMilk = new Milk();
            beverages.Add(chocolateMilk);

            Beverage demiCreme = new Espresso();
            demiCreme = new Cream(demiCreme);
            beverages.Add(demiCreme);

            Beverage latteMacchiato = new SteamedMilkBev();
            latteMacchiato = new BevToCon(latteMacchiato, new Espresso());
            latteMacchiato = new MilkFoam(latteMacchiato);
            beverages.Add(latteMacchiato);

            Beverage freddo = new Espresso();
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            beverages.Add(freddo);

            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new WhippedCream(frappuccino);
            beverages.Add(frappuccino);

            Beverage caramelFrappuchino = new Espresso();
            caramelFrappuchino = new Ice(caramelFrappuchino);
            caramelFrappuchino = new SteamedMilk(caramelFrappuchino);
            caramelFrappuchino = new CreamAndSyrup(caramelFrappuchino);
            beverages.Add(caramelFrappuchino);

            Beverage frappe = new Espresso();
            frappe = new SteamedMilk(frappe);
            frappe = new BevToCon(frappe, new IceCream());
            beverages.Add(frappe);

            Beverage irishCoffee = new Espresso();
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new WhippedCream(irishCoffee);
            beverages.Add(irishCoffee);

            PrintBeverages(beverages);
        }

        static void PrintBeverages(List<Beverage> beverages)
        {
            foreach (Beverage drink in beverages)
            {
                Console.WriteLine(drink.GetDescription() + " $" + drink.cost().ToString("#.##"));
            }
        }
    }
}