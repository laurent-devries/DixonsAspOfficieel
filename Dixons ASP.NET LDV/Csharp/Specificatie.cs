using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Specificatie
    {
        public int SpecificatieId { get; set; }
        public string Naam { get; set; }

        public Specificatie(int specificatieId, string naam)
        {
            SpecificatieId = specificatieId;
            Naam = naam;
        }
    }
}