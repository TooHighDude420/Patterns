using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DecoratorPattern.Helpers
{
    internal class ConToBev : Beverage
    {
        private Beverage parent;

        public ConToBev(Beverage parent)
        {
            this.parent = parent;
            description = parent.GetDescription();
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double cost()
        {
            return parent.cost();
        }
    }
}
