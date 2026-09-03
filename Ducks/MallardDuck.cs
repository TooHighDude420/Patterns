using StrategyPattern.Behaviours.Fly;
using StrategyPattern.Behaviours.Quacks;
using StrategyPattern.Behaviours.Swim;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.quackBehavior = new RegularQuack();
            this.flyBehavior = new FlyWithWings();
            this.swimBehavior = new Float();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}
