using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using _2017_VJ_SE2_BP3.Interfaces;

namespace _2017_VJ_SE2_BP3.Classes
{
    public class Vrachtwagen : Voertuig, IVrachtVervoerder
    {
        //properties
        public int MaximaalGewicht { get; private set; }
        public decimal LaadVolume { get; private set; }

        //constructor
        public Vrachtwagen(string kenteken, int kilometersperliter, int maximaalgewicht, decimal laadvolume)
            : base(kenteken, kilometersperliter)
        {
            this.MaximaalGewicht = maximaalgewicht;
            this.LaadVolume = laadvolume;
        }

        //methods
        //haalt het laad volume op
        public decimal GetLaadVolume()
        {
            return LaadVolume;
        }
        //haalt het maximale gewicht op
        public int GetMaximaalGewicht()
        {
            return MaximaalGewicht;
        }

        public override string ToString()
        {
            return "Vrachtwagen met kenteken: " + Kenteken + ", maximaal gewicht: " + MaximaalGewicht + ", laadvolume: " + LaadVolume;
        }
    }
}
