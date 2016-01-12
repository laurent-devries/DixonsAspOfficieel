using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Exemplaar
    {
        public int Serienummer { get; set; }
        public decimal Verkoopprijs { get; set; }
        public Product Product { get; set; }

        public Exemplaar(int serienummer, decimal verkoopprijs, Product product)
        {
            Serienummer = serienummer;
            Verkoopprijs = verkoopprijs;
            Product = product;
        }
    }
}