using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    internal interface Internet
    {
        void ConnectTo(string site);
    }
}
