using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck
    {
        private QuackBehavior quackBehavior;
        private FlyBehavior flyBehavior;
        private SwimBehavior swimBehavior;

        public QuackBehavior QuackBehavior { set { quackBehavior = value; } }
        public FlyBehavior FlyBehavior { set { flyBehavior = value; } }
        public SwimBehavior SwimBehavior { set { SwimBehavior = value; } }

        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformSwim()
        {
            swimBehavior.Swim();
        }
    }
}
