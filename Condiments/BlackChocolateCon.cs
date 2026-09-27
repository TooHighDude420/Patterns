using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class BlackChocolateCon : CondimentDecorator
    {
        public BlackChocolateCon(Beverage beverage) : base(beverage) { }

        public override double BaseCosts()
        {
            return 0.50 + Parent.costs();
        }

        public override string GetDescription()
        {
            return Parent.GetDescription() + ", Black Chocolate";
        }
    }
}
