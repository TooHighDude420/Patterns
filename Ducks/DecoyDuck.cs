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
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            this.quackBehavior = new MuteQuack();
            this.flyBehavior = new FlyNoWay();
            this.swimBehavior = new Float();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
