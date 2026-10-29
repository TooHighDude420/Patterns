namespace TemplateMethodPattern
{
    public class ChocoMilk : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Adding powder to the milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding whipped cream");
        }
    }
}
