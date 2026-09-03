using StrategyPattern.Behaviours.Swim;
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
            this.swimBehavior = new Sink();
        }

        public override void Display()
        {
            Console.WriteLine("i am a robot duck");
        }
    }
}
