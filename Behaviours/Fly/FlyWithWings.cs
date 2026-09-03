using StrategyPattern.Interfaces.FlyBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Fly
{
    internal class FlyWithWings:FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I’m flying using my wings!");
        }
    }
}
