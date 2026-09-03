using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            Duck redheadDuck = new RedheadDuck();
            Duck decoyDuck = new DecoyDuck();
            Duck rubberDuck = new RubberDuck();
            Duck robotDuck = new RobotDuck();

            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();

            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
            redheadDuck.PerformSwim();

            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
            decoyDuck.PerformSwim();

            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
            rubberDuck.PerformSwim();

            robotDuck.PerformSwim();
        }
    }
}