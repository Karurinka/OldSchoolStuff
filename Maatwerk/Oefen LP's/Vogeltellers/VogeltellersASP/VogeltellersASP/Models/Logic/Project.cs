using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogeltellersASP.Models.Logic
{
    public class Project
    {
        //properties
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public string GebiedNaam { get; private set; }
        public string Kaart { get; private set; }
        private List<Bezoek> bezoeken;

        //constructor
        public Project(int id, string naam, string gebiedNaam)
        {
            this.ID = id;
            this.Naam = naam;
            this.GebiedNaam = gebiedNaam;
        }

        public Project(int id)
        {
            this.ID = id;
        }

        //methods
        public List<Bezoek> HaalBezoekenOp(int projectid)
        {
            List<Bezoek> result = new List<Bezoek>();
            foreach (Bezoek b in bezoeken)
            {
                if (projectid == ID)
                {
                    result.Add(b);
                }
                return result;
            }
            return null;
        }

        public void SlaBezoekenOpInDatabase()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            bool antwoord = false;

            if (obj is Project)
            {
                Project andere = (Project)obj;

                bool isHetIDGelijk = this.ID == andere.ID;

                bool zijnDeNamenGelijk = this.Naam == andere.Naam;

                bool zijnDeGebiedNamenGelijk = this.GebiedNaam == andere.GebiedNaam;

                antwoord = isHetIDGelijk && zijnDeNamenGelijk && zijnDeGebiedNamenGelijk;
            }
            return antwoord;
        }
    }
}
