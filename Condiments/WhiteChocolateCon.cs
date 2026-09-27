using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class WhiteChocolateCon : CondimentDecorator
    {
        public WhiteChocolateCon(Beverage beverage) : base(beverage) { }

        public override double BaseCosts()
        {
            return 0.50 + Parent.costs();
        }

        public override string GetDescription()
        {
            return Parent.GetDescription() + ", White Chocolate";
        }
    }
}
