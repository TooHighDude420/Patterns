using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class WaterCon : CondimentDecorator
    {
        public WaterCon(Beverage beverage) : base(beverage) { }
        private Beverage basedOn = new Water();

        public override double cost()
        {
            return basedOn.cost() + Parent.cost();
        }

        public override string GetDescription()
        {
            return Parent.GetDescription() + $", {basedOn.GetDescription()}";
        }
    }
}
