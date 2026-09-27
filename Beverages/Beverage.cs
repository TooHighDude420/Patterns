using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL = 1,
        GRANDE = 2,
        VENDI = 3
    }

    internal abstract class Beverage
    {
        public Size Size { get { return size; } set { size = value; } }
        private Size size;

        protected string description = "Unknown";

        public Beverage(Size size)
        {
            this.size = size;
        }

        public virtual string GetDescription()
        {
            return description;
        }

        public double BaseCosts()
        {
            return (int)this.size + ((int)this.size * .1f) + cost();
        }

        public abstract double cost();
    }
}
