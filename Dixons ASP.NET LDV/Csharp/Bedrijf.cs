using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Bedrijf : Account
    {
        public string Bedrijfsnaam { get; set; }
        public string Ondernemingsnummer { get; set; }
        public string BtwNummer { get; set; }

        public Bedrijf(int accountId, string voornaam, string achternaam, string telefoonnummer, bool smsFunctie, string mobielNummer, DateTime geboortedatum, string twitter, bool nieuwsbrief, string email, string wachtwoord, string soort, string bedrijfsnaam, string ondernemingsnummer, string btwNummer) 
            : base(accountId, voornaam, achternaam, telefoonnummer, smsFunctie, mobielNummer, geboortedatum, twitter, nieuwsbrief, email, wachtwoord, soort)
        {
            Bedrijfsnaam = bedrijfsnaam;
            Ondernemingsnummer = ondernemingsnummer;
            BtwNummer = btwNummer;
        }
    }
}