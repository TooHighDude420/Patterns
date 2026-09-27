using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class SteamedMilkBev : Beverage
    {
        public SteamedMilkBev(Size? size = null) : base(size)
        {
            description = "Steamed Milk";
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
