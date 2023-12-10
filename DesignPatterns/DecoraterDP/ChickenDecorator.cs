using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoraterDP
{
    internal class ChickenDecorator : Decorator
    {
        public ChickenDecorator(Pizza pizza) : base(pizza)
        {
        }

        public override string makePizza()
        {
            return base.makePizza()+" with chicken";
        }
    }
}
