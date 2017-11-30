using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2017_VJ_SE2_BP3.Interfaces;

namespace _2017_VJ_SE2_BP3.Classes
{
    public class Auto : Voertuig, IPersonenVervoerder
    {
        //properties
        public int AantalPasagiers { get; private set; }

        //constructor
        public Auto(string kenteken, int kilometersperliter, int aantalpasagiers)
            : base(kenteken, kilometersperliter)
        {
            this.AantalPasagiers = aantalpasagiers;
        }

        //methods
        //haalt het aantal passagiers op
        public int GetAantalPassagiers()
        {
            return AantalPasagiers;
        }

        public override string ToString()
        {
            return "Auto met kenteken: " + Kenteken + ", aantal passagiers: " + AantalPasagiers;
        }
    }
}
