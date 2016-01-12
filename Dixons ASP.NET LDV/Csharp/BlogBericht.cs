using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class BlogBericht
    {
        public int BlogBerichtId { get; set; }
        public string Titel { get; set; }
        public DateTime Datum { get; set; }
        public string Tekst { get; set; }
        public string AfbeeldingPath { get; set; }

        public Categorie Categorie { get; set; }

        public BlogBericht(int blogBerichtId, string titel, DateTime datum, string tekst, string afbeeldingPath, Categorie categorie)
        {
            BlogBerichtId = blogBerichtId;
            Titel = titel;
            Datum = datum;
            Tekst = tekst;
            AfbeeldingPath = afbeeldingPath;
            Categorie = categorie;
        }
    }
}