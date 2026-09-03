using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Swim
{
    internal class Sink: SwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("i am sinking");
        }
    }
}
