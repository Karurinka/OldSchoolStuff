using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakkerijGoedGeSpelt.Classes
{
    [Serializable]
    public class Brood : Broodje
    {
        // properties
        public BroodSoort BroodSoort { get; private set; }

        // constructor
        public Brood()
        {
                
        }
        public Brood(string naam, double prijs, string beschrijving, BroodSoort broodsoort)
            :base(naam, prijs, beschrijving)
        {
            this.BroodSoort = broodsoort;
        }
    }
}
