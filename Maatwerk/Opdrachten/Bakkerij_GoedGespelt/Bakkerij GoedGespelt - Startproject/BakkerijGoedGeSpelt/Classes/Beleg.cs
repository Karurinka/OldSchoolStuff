using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijGoedGeSpelt.Classes
{
    public class Beleg : Broodje
    {
        // Een broodje mag maar maximaal vijf soorten beleg bevatten
        // properties
        public BelegSoort BelegSoort { get; private set; }

        // constructor
        public Beleg(string naam, double prijs, string beschrijving, BelegSoort belegsoort)
            :base(naam, prijs, beschrijving)
        {
            this.BelegSoort = belegsoort;
        }

        public Beleg(string naam, BelegSoort belegsoort, double prijs)
            :base(naam, prijs)
        {
            this.BelegSoort = belegsoort;
        }

        public override bool Equals(object obj)
        {
            bool antwoord = false;

            if (obj is Beleg)
            {
                Beleg other = (Beleg)obj;

                bool zijnDeNamenGelijk = this.Naam.Equals(other.Naam);
                antwoord = zijnDeNamenGelijk;
            }
            return antwoord;
        }
    }
}
