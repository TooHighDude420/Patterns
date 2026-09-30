using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Factories;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory starbuzz = new StarBuzzz();

            starbuzz.OrderCoffee(CoffeTypes.ESPRESSO, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.DOPPIO, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.LUNGO);
            starbuzz.OrderCoffee(CoffeTypes.MACCIATO, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.CORRETO, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.CONPANNA, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.CAPPUCHINO);
            starbuzz.OrderCoffee(CoffeTypes.AMERICANO, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.CAFFELATTE, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.FLATWHITE, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.ROMANO);
            starbuzz.OrderCoffee(CoffeTypes.MARACCHINO, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.MOCCHA, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.BICERIN, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.BREVE, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.RAFCOFFEE, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.MEADRAF);
            starbuzz.OrderCoffee(CoffeTypes.GELATO);
            starbuzz.OrderCoffee(CoffeTypes.CAFEALLOGATO, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.VIENNACOFFEE, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.GLACE, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.CHOCOLATEMILK, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.DEMICREME, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.LATTEMACCHIATO, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.FREDDO, Size.GRANDE);
            starbuzz.OrderCoffee(CoffeTypes.FRAPPUCCINO, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.CARAMELFRAPPUCHINO);
            starbuzz.OrderCoffee(CoffeTypes.FRAPPE, Size.VENDI);
            starbuzz.OrderCoffee(CoffeTypes.IRISHCOFFEE);
        }
    }
}