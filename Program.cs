using TemplateMethodPattern.CompareTo;

namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleTea simpleTea = new SimpleTea();
            SimpleCoffee simpleCoffee = new SimpleCoffee();

            simpleTea.prepareRecipe();
            simpleCoffee.PrepareRecipe();

            Console.WriteLine("\n\nNow with abstracted classes\n\n");

            CaffeineBeverage tea = new Tea();
            CaffeineBeverage coffee = new Coffee();
            CaffeineBeverage choco = new ChocoMilk();


            choco.PrepareRecipe();
            tea.PrepareRecipe();
            coffee.PrepareRecipe();

            Console.WriteLine("\n\n Now with hooked classes\n\n");

            CaffeineBeverageWithHook hookedTea = new TeaWithHook();
            CaffeineBeverageWithHook hookedCoffee = new CoffeeWithHook();
            CaffeineBeverageWithHook hookedSoda = new SodaWithHook();


            hookedTea.PrepareRecipe();
            hookedCoffee.PrepareRecipe();
            hookedSoda.PrepareRecipe();

            // You'll need this method for the second part of the Template Method Pattern
            // Dik naar dun
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 2),
                new Duck("Donald", 10),
                new Duck("Huey", 2)
            };

            Console.WriteLine("Before sorting:");
            Display(ducks);

            ducks.Sort();
            
            Console.WriteLine("After sorting:");
            Display(ducks);

        }

        // You'll need this method for the second part of the Template Method Pattern
        public static void Display(object[] objects)
        {
            foreach (object o in objects)
            {
                Console.WriteLine(o.ToString());
            }
            Console.WriteLine("");
        }
    }
}