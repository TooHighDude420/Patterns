using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Beverage> beverages = new List<Beverage>();

            Beverage espresso = new Espresso(Size.GRANDE);
            beverages.Add(espresso);

            Beverage doppio = new Espresso(Size.VENDI);
            doppio = new EspressoCon(doppio);
            beverages.Add(doppio);

            Beverage lungo = new Espresso();
            lungo = new WaterCon(lungo);
            beverages.Add(lungo);

            Beverage macchiato = new Espresso(Size.GRANDE);
            macchiato = new MilkFoam(macchiato);
            beverages.Add(macchiato);

            Beverage correto = new Espresso(Size.VENDI);
            correto = new Liqour(correto);
            beverages.Add(correto);

            Beverage conPanna = new Espresso(Size.GRANDE);
            conPanna = new WhippedCream(conPanna);
            beverages.Add(conPanna);

            Beverage cappuchino = new Espresso();
            cappuchino = new SteamedMilk(cappuchino);
            cappuchino = new MilkFoam(cappuchino);
            beverages.Add(cappuchino);

            Beverage americano = new Espresso(Size.VENDI);
            americano = new WaterCon(americano);
            americano = new WaterCon(americano);
            beverages.Add(americano);

            Beverage caffeLatte = new Espresso(Size.VENDI);
            caffeLatte = new SteamedMilk(caffeLatte);
            caffeLatte = new MilkFoam(caffeLatte);
            beverages.Add(caffeLatte);

            Beverage flatWhite = new Espresso(Size.GRANDE);
            flatWhite = new SteamedMilk(flatWhite);
            flatWhite = new SteamedMilk(flatWhite);
            beverages.Add(flatWhite);

            Beverage romano = new Espresso();
            romano = new Lemon(romano);
            beverages.Add(romano);

            Beverage maracchino = new Espresso(Size.VENDI);
            maracchino = new ChocolateCon(maracchino);
            maracchino = new MilkFoam(maracchino);
            beverages.Add(maracchino);

            Beverage moccha = new Espresso(Size.GRANDE);
            moccha = new ChocolateCon(moccha);
            moccha = new MilkFoam(moccha);
            moccha = new WhippedCream(moccha);
            beverages.Add(moccha);

            Beverage bicerin = new Espresso(Size.GRANDE);
            bicerin = new BlackChocolateCon(bicerin);
            bicerin = new WhiteChocolateCon(bicerin);
            bicerin = new WhippedCream(bicerin);
            beverages.Add(bicerin);

            Beverage breve = new Espresso(Size.VENDI);
            breve = new MilkCon(breve);
            breve = new MilkFoam(breve);
            beverages.Add(breve);

            Beverage rafCoffee = new Espresso(Size.VENDI);
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

            Beverage cafeeAllogato = new IceCream(Size.VENDI);
            cafeeAllogato = new EspressoCon(cafeeAllogato);
            beverages.Add(cafeeAllogato);
            
            Beverage viennaCoffee = new Espresso(Size.VENDI);
            viennaCoffee = new WhippedCream(viennaCoffee);
            beverages.Add(viennaCoffee);

            Beverage glace = new Espresso(Size.GRANDE);
            glace = new IceCreamCon(glace);
            beverages.Add(glace);

            Beverage chocolateMilk = new Cocao();
            chocolateMilk = new MilkCon(chocolateMilk);
            beverages.Add(chocolateMilk);

            Beverage demiCreme = new Espresso(Size.VENDI);
            demiCreme = new Cream(demiCreme);
            beverages.Add(demiCreme);

            Beverage latteMacchiato = new SteamedMilkBev();
            latteMacchiato = new EspressoCon(latteMacchiato);
            latteMacchiato = new MilkFoam(latteMacchiato);
            beverages.Add(latteMacchiato);

            Beverage freddo = new Espresso(Size.GRANDE);
            freddo = new Liqour(freddo);
            freddo = new Ice(freddo);
            beverages.Add(freddo);

            Beverage frappuccino = new Espresso(Size.VENDI);
            frappuccino = new Ice(frappuccino);
            frappuccino = new SteamedMilk(frappuccino);
            frappuccino = new WhippedCream(frappuccino);
            beverages.Add(frappuccino);

            Beverage caramelFrappuchino = new Espresso();
            caramelFrappuchino = new Ice(caramelFrappuchino);
            caramelFrappuchino = new SteamedMilk(caramelFrappuchino);
            caramelFrappuchino = new CreamAndSyrup(caramelFrappuchino);
            beverages.Add(caramelFrappuchino);

            Beverage frappe = new Espresso(Size.VENDI);
            frappe = new SteamedMilk(frappe);
            frappe = new IceCreamCon(frappe);
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
                Console.WriteLine(drink.GetDescription() + " $" + drink.costs().ToString("#.##") + " size:" + drink.Size.ToString());
            }
        }
    }
}