using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BevToCon : CondimentDecorator
    {
        private Beverage basedOn;
        
        public BevToCon(Beverage beverage, Beverage based) : base(beverage) {
            basedOn = based;
        }

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
