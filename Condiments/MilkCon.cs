using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class MilkCon : CondimentDecorator
    {
        public MilkCon(Beverage beverage) : base(beverage) { }

        public override double BaseCosts()
        {
            return 0.10 + Parent.costs();
        }

        public override string GetDescription()
        {
            return Parent.GetDescription() + ", Milk";
        }
    }
}
