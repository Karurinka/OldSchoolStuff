using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2017_VJ_SE2_BP3.Interfaces;
using System.IO;
using _2017_VJ_SE2_BP3.Exceptions;

namespace _2017_VJ_SE2_BP3.Classes
{
    public abstract class Voertuig : IComparable<Voertuig>
    {
        //properties
        public string Kenteken { get; private set; }
        public int KilometerPerLiter { get; private set; }
        public bool InGarage { get; private set; }

        //constructor
        public Voertuig(string kenteken, int kilometerperliter)
        {
            this.Kenteken = kenteken;
            this.KilometerPerLiter = kilometerperliter;
        }

        //methods
        //haalt de boolean ingarage op
        public bool GetInGarage()
        {
            return InGarage;
        }

        //zet een auto in de garage door de ingarage bool op true te zetten
        public void SetInGarage(bool ingarage)
        {
            InGarage = ingarage;
        }

        //berekent hoeveel brandstof er gebruikt wordt
        public decimal BerekenVerbruikteBrandstof(int kilometers)
        {
            return kilometers / KilometerPerLiter;
        }

        //de nieuwe compareTo methode
        public int CompareTo(Voertuig other)
        {
            return this.Kenteken.CompareTo(other.Kenteken);
        }

        //hier wordt de toString methode overschreven
        public override string ToString()
        {
            return "Voertuig met kenteken: " + Kenteken + ", kilometer per liter" + KilometerPerLiter;
        }
    }
}
