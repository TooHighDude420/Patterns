using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water(Size? size = null) : base(size)
        {
            description = "Water";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double BaseCosts()
        {
            return 0.50;
        }
    }
}
