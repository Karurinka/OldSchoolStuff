using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotenApp.Logic
{
    public abstract class Artiekel
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public decimal Huurprijs { get; private set; }

        //constructor
        public Artiekel(int id, string naam, decimal huurprijs)
        {
            this.ID = id;
            this.Naam = naam;
            this.Huurprijs = huurprijs;
        }

        //methods
        public override string ToString()
        {
            return Naam + ", " + "Huurprijs:  €" + Huurprijs;
        }
    }
}
