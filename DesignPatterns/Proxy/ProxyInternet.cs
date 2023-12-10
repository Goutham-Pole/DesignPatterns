using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    internal class ProxyInternet : Internet
    {
        RealInternet realInternet;
        public void ConnectTo(string site)
        {
         if(realInternet is null)
                realInternet = new RealInternet();
         realInternet.NavigateTo(site);
        }
    }
}
