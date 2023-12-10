using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    internal class RealInternet : Internet
    {
        List<string> bannedSites = new List<string>() { "www.abc.com", "www.example.com", "www.localhost.com" };
        public void ConnectTo(string site)
        {
            if (!bannedSites.Contains(site)) 
            {
                Console.WriteLine($"Connecting to.. {site}");
                NavigateTo(site);
                return;
            }
            else
            {
                throw new Exception("Access Denied");
            }

        }

        public void NavigateTo(string site)
        {
            Console.WriteLine($"opening.. {site}");
        }
    }
}
