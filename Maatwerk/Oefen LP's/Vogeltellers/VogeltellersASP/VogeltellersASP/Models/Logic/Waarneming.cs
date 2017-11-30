using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VogeltellersASP.Models.Logic
{
    public class Waarneming
    {
        //properties
        public int ID { get; private set; }
        public int Vogel_ID { get; private set; }
        public string Categorie { get; private set; }
        public string Afkorting { get; private set; }
        public int Punten { get; private set; }

        //constructor
        public Waarneming(int id, int vogel_id, string categorie, string afkorting, int punten)
        {
            this.ID = id;
            this.Vogel_ID = vogel_id;
            this.Categorie = categorie;
            this.Afkorting = afkorting;
            this.Punten = punten;
        }

        //methods
        public override string ToString()
        {
            return "Afkorting: " + Afkorting + "Vogel ID: " +  Vogel_ID + "Aantal punten" + Punten;
        }
    }
}