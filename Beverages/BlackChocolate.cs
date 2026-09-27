using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class BlackChocolate : Beverage
    {
        public BlackChocolate(Size size) : base(size)
        {
            description = "Black Chocolate";
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
