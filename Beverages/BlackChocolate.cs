using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class BlackChocolate : Beverage
    {
        public BlackChocolate(Size? size = null) : base(size)
        {
            description = "Black Chocolate";
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
