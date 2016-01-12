using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Dixons_ASP.NET_LDV.Csharp
{
    public abstract class Account
    {
        public int AccountId { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Telefoonnummer { get; set; }
        public bool SmsFunctie { get; set; }
        public string MobielNummer { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Twitter { get; set; }
        public bool Nieuwsbrief { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Soort { get; set; }
        
        public List<Order> Orders { get; set; }

        public Account(int accountId, string voornaam, string achternaam, string telefoonnummer, bool smsFunctie, string mobielNummer, DateTime geboortedatum, string twitter, bool nieuwsbrief, string email, string wachtwoord, string soort)
        {
            AccountId = accountId;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Telefoonnummer = telefoonnummer;
            SmsFunctie = smsFunctie;
            MobielNummer = mobielNummer;
            Geboortedatum = geboortedatum;
            Twitter = twitter;
            Nieuwsbrief = nieuwsbrief;
            Email = email;
            Wachtwoord = wachtwoord;
            Soort = soort;
        }
    }
}