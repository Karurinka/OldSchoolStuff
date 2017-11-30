using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;

namespace VogeltellersASP.Models.Logic
{
    public class Bezoek
    {
        //properties
        public int ID { get; private set; }
        public int BezoekNummer { get; private set; }
        public int AantalPunten { get; private set; }
        public DateTime Datum { get; private set; }
        private List<Waarneming> Waarnemingen;

        //constructor
        public Bezoek(int id, int bezoekNummer, int aantalPunten, DateTime datum)
        {
            this.ID = id;
            this.BezoekNummer = bezoekNummer;
            this.AantalPunten = aantalPunten;
            this.Datum = datum;
        }

        public Bezoek(int id)
        {
            this.ID = id;
        }

        //methods
        public List<Waarneming> HaalWaarnemingenOp(int bezoekid)
        {
            List<Waarneming> result = new List<Waarneming>();
            foreach (Waarneming w in Waarnemingen)
            {
                if (bezoekid == ID)
                {
                    result.Add(w);
                }
                return result;
            }
            return null;
        }

        public int BerekenBroedpaar(Vogelsoort vogel)
        {
            int antwoord;
            antwoord = AantalPunten / vogel.BroedpaarCijfer;
            return antwoord;
        }

        public List<Waarneming> DraaiWaarnemingUit(int id)
        {
            List<Waarneming> result = new List<Waarneming>();
            foreach (Waarneming w in Waarnemingen)
            {
                try
                {
                    if (this.ID == id)
                    {
                        result.Add(w);
                    }
                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return null;
        }

        public Waarneming ZoekWaarneming(Point begin, Point eind)
        {
            throw new NotImplementedException();
        }
    }
}