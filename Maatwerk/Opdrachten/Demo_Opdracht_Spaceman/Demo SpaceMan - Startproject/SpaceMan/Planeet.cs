using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMan
{
    public class Planeet
    {
        // properties
        public string Naam { get; private set; }
        public bool Bewoond { get; private set; }
        public DateTime AankomstDatum { get; private set; }
        public DateTime VertrekDatum { get; private set; }

        // constructor
        public Planeet(string naam, bool bewoond)
        {
            this.Naam = naam;
            this.Bewoond = bewoond;
        }

        public Planeet(string naam, bool bewoond, DateTime aankomstdatum, DateTime vertrekdatum)
        {
            this.Naam = naam;
            this.Bewoond = bewoond;
            this.AankomstDatum = aankomstdatum;
            this.VertrekDatum = vertrekdatum;
        }
    }
}
