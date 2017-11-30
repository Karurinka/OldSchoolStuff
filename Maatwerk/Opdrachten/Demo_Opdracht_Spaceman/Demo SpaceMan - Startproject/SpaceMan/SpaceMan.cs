using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceMan
{
    public class SpaceMan
    {
        // properties
        public string Naam { get; private set; }
        public int Leeftijd { get; private set; }
        public List<Planeet> PlanetenBezocht { get; private set; }

        // constructor
        public SpaceMan(string naam, int leeftijd)
        {
            this.Naam = naam;
            this.Leeftijd = leeftijd;
            PlanetenBezocht = new List<Planeet>();
        }

        // methods
        public bool VoegBezochtePlaneetToe(Planeet planeet)
        {
            bool succes = true;

            foreach( Planeet p in PlanetenBezocht)
            {
                if (p.Naam == planeet.Naam)
                {
                    succes = false;
                }
            }

            if (succes)
            {
                PlanetenBezocht.Add(planeet);
            }
            return succes;
        }

        public List<Planeet> HaalBezochteBewoondePlaneten()
        {
            List<Planeet> bewoondePlaneten = new List<Planeet>();

            foreach (Planeet p in PlanetenBezocht)
            {
                if (p.Bewoond)
                {
                    bewoondePlaneten.Add(p);
                }
            }

            return bewoondePlaneten;
        }

        public List<SpaceMan> AlleSpaceMenOpXPlaneet(Planeet planeet)
        {
            List<SpaceMan> spaceMen = new List<SpaceMan>();

            foreach (SpaceMan space in spaceMen)
            {
                if (PlanetenBezocht.Contains(planeet))
                {
                    spaceMen.Add(space);
                }      
            }
            return spaceMen;
        }

        //public override bool Equals(object obj)
        //{
        //    bool answer = false;
        //    if (obj is SpaceMan)
        //    {
        //        SpaceMan other = (SpaceMan) obj;
        //        bool sameName = this.Naam.Equals(other.Naam);
        //        answer = sameName;
        //    }
        //    return answer;
        //}
    }
}
