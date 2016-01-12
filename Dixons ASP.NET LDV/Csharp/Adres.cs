using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Adres
    {
        public int AdresId { get; set; }
        public string Postcode { get; set; }
        public int Huisnummer { get; set; }
        public string Straat { get; set; }
        public string Plaats { get; set; }

        public Adres(int adresId, string postcode, int huisnummer, string straat, string plaats)
        {
            AdresId = adresId;
            Postcode = postcode;
            Huisnummer = huisnummer;
            Straat = straat;
            Plaats = plaats;
        }
    }
}