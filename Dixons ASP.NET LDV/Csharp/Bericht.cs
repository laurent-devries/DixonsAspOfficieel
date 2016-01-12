using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Bericht
    {
        public int BerichtId { get; set; }
        public string Onderwerp { get; set; }
        public string Tekst { get; set; }

        public Bericht(int berichtId, string onderwerp, string tekst)
        {
            BerichtId = berichtId;
            Onderwerp = onderwerp;
            Tekst = tekst;
        }
    }
}