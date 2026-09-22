using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage) : base(beverage) { }

        public override double cost()
        {
            return 0.10 + Parent.cost();
        }

        public override string GetDescription()
        {
            return Parent.GetDescription() + ", MilkFoam";
        }
    }
}
