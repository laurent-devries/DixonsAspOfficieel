using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public class Particulier : Account
    {
        public Particulier(int accountId, string voornaam, string achternaam, string telefoonnummer, bool smsFunctie, string mobielNummer, DateTime geboortedatum, string twitter, bool nieuwsbrief, string email, string wachtwoord, string soort) : base(accountId, voornaam, achternaam, telefoonnummer, smsFunctie, mobielNummer, geboortedatum, twitter, nieuwsbrief, email, wachtwoord, soort)
        {

        }
    }
}