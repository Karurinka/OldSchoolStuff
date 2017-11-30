using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Logic
{
    public class Water
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public decimal Huurprijs { get; private set; }
        public decimal Sluisgeld { get; private set; }

        //constructor
        public Water(int id, string naam, decimal huurprijs, decimal sluisgeld)
        {
            this.ID = id;
            this.Naam = naam;
            this.Huurprijs = huurprijs;
            this.Sluisgeld = sluisgeld;
        }

        //methods
        public override string ToString()
        {
            return "Waternaam: " + Naam + ", Huurprijs: €" + Huurprijs + ", Sluisgeld: €" + Sluisgeld; 
        }
    }
}
