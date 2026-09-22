using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal abstract class CondimentDecorator : Beverage
    {
        public Beverage Parent { get { return parent; } }
        private Beverage parent;

        public CondimentDecorator(Beverage parent)
        {
            this.parent = parent;
        }

        public abstract override string GetDescription();

    }
}
