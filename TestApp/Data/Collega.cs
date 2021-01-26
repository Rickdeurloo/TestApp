using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Data
{
    public class Collega
    {
        public string Naam { get; set; }
        public string Email { get; set; }
        public string TelefoonNummer { get; set; }

        public Collega(string naam, string email, string telefoonNummer)
        {
            Naam = naam;
            Email = email;
            TelefoonNummer = telefoonNummer;
        }
    }

}
