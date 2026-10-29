namespace TemplateMethodPattern
{
    internal class SodaWithHook : CaffeineBeverageWithHook
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
        public override bool CustomerWantsCondement()
        {
            Console.WriteLine("Would you like lemon with your soda (y/n)?");
            string answer = Console.ReadLine();
            return answer.ToLower().StartsWith('y');
        }
    }
}
