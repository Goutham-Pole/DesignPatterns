using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoraterDP
{
    internal class PepperoniDecorator : Decorator
    {
        public PepperoniDecorator(Pizza pizza) : base(pizza)
        {
        }
        public override string makePizza()
        {
            return base.makePizza() + " with pepperoni";
        }
    }
}
