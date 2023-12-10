using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoraterDP
{
    internal class PlainPizza : Pizza
    {
        public string makePizza()
        {
            return "Plain pizza";
        }
    }
}
