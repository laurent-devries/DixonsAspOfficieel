using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Categorie
    {
        public int CategorieId { get; set; }
        public string CategorieNaam { get; set; }
        public int CategorieIdParent { get; set; }

        public Categorie(int categorieId, string categorieNaam, int categorieIdParent)
        {
            CategorieId = categorieId;
            CategorieNaam = categorieNaam;
            CategorieIdParent = categorieIdParent;
        }

        public override string ToString()
        {
            return CategorieNaam;
        }
    }
}