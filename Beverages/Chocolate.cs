using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate(Size size) : base(size)
        {
            description = "Chocolate";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
