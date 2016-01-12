using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Datum { get; set; }
        public List<Exemplaar> Exemplaren { get; set; }

        public Account Account;
        public Adres BezorgAdres { get; set; }
        public Adres FactuurAdres { get; set; }

        public Order(int orderId, Account account, DateTime datum, List<Exemplaar> exemplaren, Adres bezorgAdres, Adres factuurAdres)
        {
            OrderId = orderId;
            Account = account;
            Datum = datum;
            Exemplaren = exemplaren;
            BezorgAdres = bezorgAdres;
            FactuurAdres = factuurAdres;
        }
    }
}