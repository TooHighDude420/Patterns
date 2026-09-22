using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water()
        {
            description = "Water";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double cost()
        {
            return 0.50;
        }
    }
}
