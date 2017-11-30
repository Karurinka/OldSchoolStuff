using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2017_VJ_SE2_BP3.Interfaces;

namespace _2017_VJ_SE2_BP3.Classes
{
    public class Bestelwagen : Voertuig, IVrachtVervoerder, IPersonenVervoerder
    {
        //properties
        public int AantalPasagiers { get; private set; }
        public int MaximaalGewicht { get; private set; }
        public decimal LaadVolume { get; private set; }

        //constructor
        public Bestelwagen(string kenteken, int kilometersperliter, int aantalpasagiers, int maximaalgewicht, decimal laadvolume)
            : base(kenteken, kilometersperliter)
        {
            this.AantalPasagiers = aantalpasagiers;
            this.MaximaalGewicht = maximaalgewicht;
            this.LaadVolume = laadvolume;
        }

        //methods
        //haalt het maximale gewicht op
        public int GetMaximaalGewicht()
        {
            return MaximaalGewicht;
        }

        //haalt het laadvolume op
        public decimal GetLaadVolume()
        {
            return LaadVolume;
        }

        //haalt het aantal passagiers op
        public int GetAantalPassagiers()
        {
            return AantalPasagiers;
        }

        public override string ToString()
        {
            return "Bestelwagen met kenteken: " + Kenteken + ", aantal passagiers: " + AantalPasagiers
                + ", maximaal gewicht: " + MaximaalGewicht + ", laad volume: " + LaadVolume;
        }
    }
}
