using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string Beschrijving { get; set; }
        public string Bezorgtijd { get; set; }
        public string AfbeeldingPath { get; set; }

        public Categorie Categorie { get; set; }
        public List<Specificatie> Specificaties { get; set; }

        public Product(int productId, string naam, decimal prijs, string beschrijving, string bezorgtijd, string afbeeldingPath, Categorie categorie, List<Specificatie> specificaties)
        {
            ProductId = productId;
            Naam = naam;
            Prijs = prijs;
            Beschrijving = beschrijving;
            Bezorgtijd = bezorgtijd;
            AfbeeldingPath = afbeeldingPath;
            Categorie = categorie;
            Specificaties = specificaties;
        }

        public override string ToString()
        {
            return Naam;
        }
    }
}