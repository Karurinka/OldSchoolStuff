using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijGoedGeSpelt.Classes
{
    [Serializable]
    public class Broodje
    {
        // properties
        public string Naam { get; private set; }
        public double Prijs { get; private set; }
        public string NaamEnPrijs { get; private set; }
        public string Beschrijving { get; private set; }
        public BroodSoort BroodSoort { get; private set; }
        public BelegSoort BelegSoort { get; private set; }
        public List<Beleg> Beleggen { get; private set; }
        // constructor
        public Broodje()
        {
                
        }

        public Broodje(string naam, BroodSoort broodsoort)
        {
            this.Naam = naam;
            this.BroodSoort = broodsoort;
        }

        public Broodje(string naam, double prijs, string beschrijving)
        {
            this.Naam = naam;
            this.Prijs = prijs;
            this.Beschrijving = beschrijving;
        }

        public Broodje(string naam, double prijs)
        {
            this.Naam = naam;
            this.Prijs = prijs;
        }

        // methods
        public bool BelegBroodje(Beleg beleg)
        {
            bool unique = false;
            bool go = true;
            int count = 0;

            foreach (Beleg b in Beleggen)
            {
                Beleggen.Add(b);
                count = count + 1;
                unique = true;

                if (Beleggen.Contains(beleg))
                {
                    unique = false;
                    go = false;
                }
            }

            if (count > 5)
            {
                Console.Write("Het maximaal aantal aan beleg dat op een broodje mag is vijf.");
            }

            return go;
        }

        public override bool Equals(object obj)
        {
            bool antwoord = false;

            if (obj is Broodje)
            {
                Broodje other = (Broodje) obj;

                bool zijnDeNamenGelijk = this.Naam.Equals(other.Naam);
                antwoord = zijnDeNamenGelijk;
            }
            return antwoord;
        }

        public override string ToString()
        {
            NaamEnPrijs = "Naam: " + Naam + " - " + "Prijs: €" + Prijs;
            return NaamEnPrijs;
        }
    }
}
