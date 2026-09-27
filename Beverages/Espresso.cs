using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso(Size? size = null) : base(size)
        {
            description = "Espresso";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double BaseCosts()
        {
            return 1.99;
        }
    }
}
