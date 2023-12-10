using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoraterDP
{
    internal abstract class Decorator:Pizza
    {
        private readonly Pizza pizza;

        protected Decorator(Pizza pizza)
        {
            this.pizza = pizza;
        }

        public virtual string makePizza()
        {
            return pizza.makePizza();
        }
    }
}
