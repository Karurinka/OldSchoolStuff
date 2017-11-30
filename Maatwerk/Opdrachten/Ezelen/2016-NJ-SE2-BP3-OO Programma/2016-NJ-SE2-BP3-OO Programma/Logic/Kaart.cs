using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016_NJ_SE2_BP3_OO_Programma.Logic
{
    public class Kaart : IComparable<Kaart>
    {
        //properties
        public Soort Soort { get; private set; }
        public Waarde Waarde { get; private set; }

        //constructor
        public Kaart(Soort soort, Waarde waarde)
        {
            this.Soort = soort;
            this.Waarde = waarde;
        }

        //methods
        public int CompareTo(Kaart andere)
        {
            return this.Soort.CompareTo(andere.Soort);
        }

        public override string ToString()
        {
            return Soort + " " + Waarde;
        }
    }
}
