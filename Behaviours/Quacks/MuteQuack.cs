using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Behaviours.Quacks
{
    internal class MuteQuack: QuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<Silence>>");
        }
    }
}
