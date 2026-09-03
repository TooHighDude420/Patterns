using StrategyPattern.Behaviours.Fly;
using StrategyPattern.Behaviours.Quacks;
using StrategyPattern.Behaviours.Swim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.quackBehavior = new Squeak();
            this.flyBehavior = new FlyNoWay();
            this.swimBehavior = new Float();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}
