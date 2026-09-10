using StrategyPattern.Behaviours.Fly;
using StrategyPattern.Behaviours.Swim;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck: Duck
    {
        public RobotDuck()
        {
            this.FlyBehavior = new FlyWithWings();
            this.SwimBehavior = new SwimBehavior();
            this.swimBehavior = new Sink();
        }

        public override void Display()
        {
            Console.WriteLine("i am a robot duck");
        }
    }
}
